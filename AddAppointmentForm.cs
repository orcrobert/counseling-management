﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using static Google.Apis.Calendar.v3.CalendarService;


namespace subjectmanager
{
    public partial class AddAppointmentForm : Form
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
        private static string[] Scopes = { CalendarService.Scope.Calendar };
        private static string ApplicationName = "subjectmanager";
        public AddAppointmentForm()
        {
            InitializeComponent();
            appointmentDatePicker = new DateTimePicker();
            appointmentDatePicker.Format = DateTimePickerFormat.Custom;
            appointmentDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            studentNameTextBox = new System.Windows.Forms.TextBox();
            labelDate = new System.Windows.Forms.Label();
            labelStudent = new System.Windows.Forms.Label();
            scheduleButton = new System.Windows.Forms.Button();

            labelDate.Text = "Appointment Date & Time:";
            labelDate.Location = new System.Drawing.Point(20, 180);
            appointmentDatePicker.Location = new System.Drawing.Point(200, 180);
            labelStudent.Text = "Student Name:";
            labelStudent.Location = new System.Drawing.Point(20, 220);
            studentNameTextBox.Location = new System.Drawing.Point(200, 220);
            scheduleButton.Text = "Schedule Appointment";
            scheduleButton.Location = new System.Drawing.Point(200, 260);
            scheduleButton.Click += new EventHandler(ScheduleButton_Click);

            // Add to form
            this.Controls.Add(appointmentDatePicker);
            this.Controls.Add(studentNameTextBox);
            this.Controls.Add(labelDate);
            this.Controls.Add(labelStudent);
            this.Controls.Add(scheduleButton);
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM matricole", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectsComboBox.DataSource = subjectsTable;
                subjectsComboBox.DisplayMember = "name";
                subjectsComboBox.ValueMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)subjectsComboBox.SelectedItem;

            // Assuming the "name" is the column containing the subject name
            string subjectName = selectedRow["name"].ToString(); 
            MessageBox.Show("Selected Subject: " + subjectName);
            try
            {
                conn.Open();

                // Handling the number of appointments
                int appointmentCount;
                if (textBox1.Text.Length == 0)
                    appointmentCount = 1; // Default to 1 if no value is provided
                else
                {
                    try
                    {
                        appointmentCount = int.Parse(textBox1.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Number of appointments must be an integer!");
                        return;
                    }
                }

                // Update the number of appointments in the matricole table
                SqlCommand cmd = new SqlCommand("UPDATE matricole SET noOfAppointments = noOfAppointments + @appointmentCount WHERE name = @SubjectName", conn);
                cmd.Parameters.AddWithValue("@appointmentCount", appointmentCount);
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);

                int rowsAffected = cmd.ExecuteNonQuery();

                // If update was successful, insert into appointmentsDate
                if (rowsAffected > 0)
                {
                    // Assuming you have a DateTimePicker for selecting the date
                    DateTime selectedDate = appointmentDatePicker.Value; // Replace with your actual DateTimePicker control

                    // Assuming you have a TextBox for the theme of the appointment
                    string theme = themeTextBox.Text; // Replace themeTextBox with the actual TextBox control for the theme

                    // Insert the appointment details into the appointmentsDate table
                    cmd = new SqlCommand("INSERT INTO appointmentsDate (name, date, theme) VALUES (@name, @date, @theme)", conn);
                    cmd.Parameters.AddWithValue("@name", subjectName);  // Insert the selected subject name
                    cmd.Parameters.AddWithValue("@date", selectedDate); // Insert the selected date
                    cmd.Parameters.AddWithValue("@theme", theme);       // Insert the entered theme

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Appointment added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update the number of appointments!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                int appointmentCount;
                if (textBox2.Text.Length == 0)
                    appointmentCount = 1;
                else
                {
                    try
                    {
                        appointmentCount = int.Parse(textBox2.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Number of appointments must be a integer!");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("UPDATE groupAppointments SET noOfAppointments = noOfAppointments + @appointmentCount", conn);
                cmd.Parameters.AddWithValue("@appointmentCount", appointmentCount);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Appointment added successfully!");
                else
                    MessageBox.Show("Failed to add appointment!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating number of group appointments!");
            }
            finally { conn.Close(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public CalendarService AuthenticateGoogleCalendar()
        {
            UserCredential credential;
            using (var stream = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credentials.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            CalendarService service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            return service;
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = appointmentDatePicker.Value;
            string studentName = studentNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the student's name.");
                return;
            }

            CalendarService service = AuthenticateGoogleCalendar();

            Event newEvent = new Event()
            {
                Summary = $"Appointment with {studentName}",
                Location = "Your location here",
                Description = $"Appointment scheduled with {studentName}.",

                Start = new EventDateTime()
                {
                    DateTime = selectedDate,
                    TimeZone = "America/New_York"
                },
                End = new EventDateTime()
                {
                    DateTime = selectedDate.AddHours(1),
                    TimeZone = "America/New_York"
                },

                Attendees = new List<EventAttendee>()
                {
                    new EventAttendee() { Email = "student@example.com" }
                },

                Reminders = new Event.RemindersData()
                {
                    UseDefault = false,
                    Overrides = new EventReminder[]
                    {
                        new EventReminder() { Method = "email", Minutes = 24 * 60 },
                        new EventReminder() { Method = "popup", Minutes = 10 }
                    }
                }
            };

            try
            {
                EventsResource.InsertRequest request = service.Events.Insert(newEvent, "primary");
                Event createdEvent = request.Execute();
                MessageBox.Show($"Appointment scheduled successfully! Event ID: {createdEvent.Id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while scheduling the appointment: {ex.Message}");
            }
        }
    }
}
