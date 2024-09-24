using System;
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
        private static string entity = "student";
        public AddAppointmentForm()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            this.subjectsComboBox.Visible = true;
            this.textBox1.Visible = false;
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

        private void LoadParents()
        {
            this.subjectsComboBox.Visible = true;
            this.textBox1.Visible = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM parents", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectsComboBox.DataSource = subjectsTable;
                subjectsComboBox.DisplayMember = "name";
                subjectsComboBox.ValueMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading parents: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadTeachers()
        {
            this.subjectsComboBox.Visible = true;
            this.textBox1.Visible = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM teachers", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectsComboBox.DataSource = subjectsTable;
                subjectsComboBox.DisplayMember = "name";
                subjectsComboBox.ValueMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadGroups()
        {
            this.subjectsComboBox.Visible = true;
            this.textBox1.Visible = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, name FROM groupAppointments", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectsComboBox.DataSource = subjectsTable;
                subjectsComboBox.DisplayMember = "name";
                subjectsComboBox.ValueMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading groups: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadOther()
        {
            this.subjectsComboBox.Visible = false;
            this.textBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)subjectsComboBox.SelectedItem;
            string subjectName = selectedRow["name"].ToString();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                if (entity == "student")
                    cmd = new SqlCommand("UPDATE matricole SET noOfAppointments = noOfAppointments + 1 WHERE name = @SubjectName", conn);
                else if (entity == "parent")
                    cmd = new SqlCommand("UPDATE parents SET noOfAppointments = noOfAppointments + 1 WHERE name = @SubjectName", conn);
                else if (entity == "teacher")
                    cmd = new SqlCommand("UPDATE teachers SET noOfAppointments = noOfAppointments + 1 WHERE name = @SubjectName", conn);
                else if (entity == "group")
                    cmd = new SqlCommand("UPDATE groupAppointments SET noOfAppointments = noOfAppointments +1 WHERE name = @SubjectName", conn);

                int rowsAffected;

                if (entity != "other")
                {
                    cmd.Parameters.AddWithValue("@SubjectName", subjectName);

                    rowsAffected = cmd.ExecuteNonQuery();
                }
                else
                {
                    rowsAffected = 1;
                }

                if (rowsAffected > 0 || entity == "other")
                {
                    DateTime selectedDate = dateTimePicker1.Value;
                    string theme = themeTextBox.Text;

                    cmd = new SqlCommand("INSERT INTO appointmentsDate (name, date, theme, type) VALUES (@name, @date, @theme, @type)", conn);
                    
                    if (entity == "other")
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    else
                        cmd.Parameters.AddWithValue("@name", subjectName);

                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    cmd.Parameters.AddWithValue("@theme", theme);

                    if (entity == "student")
                        cmd.Parameters.AddWithValue("@type", "student");
                    else if (entity == "parent")
                        cmd.Parameters.AddWithValue("@type", "parent");
                    else if (entity == "teacher")
                        cmd.Parameters.AddWithValue("@type", "teacher");
                    else if (entity == "group")
                        cmd.Parameters.AddWithValue("@type", "group");
                    else if (entity == "other")
                        cmd.Parameters.AddWithValue("@type", "other");

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

        private void scheduleButton_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DataRowView selectedRow = (DataRowView)subjectsComboBox.SelectedItem;
            string studentName = selectedRow["name"].ToString();

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the person's name.");
                return;
            }

            CalendarService service = AuthenticateGoogleCalendar();

            Event newEvent = new Event()
            {
                Summary = $"Appointment with {studentName}",
                Location = "Your location here",
                Description = $"Appointment scheduled with {studentName} on {themeTextBox.Text}.",

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

        private void studentRadio_Click(object sender, EventArgs e)
        {
            entity = "student";
            LoadStudents();
        }

        private void parentRadio_Click(object sender, EventArgs e)
        {
            entity = "parent";
            LoadParents();
        }

        private void teacherRadio_Click(object sender, EventArgs e)
        {
            entity = "teacher";
            LoadTeachers();
        }

        private void groupRadio_Click(object sender, EventArgs e)
        {
            entity = "group";
            LoadGroups();
        }

        private void otherRadio_Click(object sender, EventArgs e)
        {
            entity = "other";
            LoadOther();
        }

        private void themeTextBox_Enter(object sender, EventArgs e)
        {
            if (themeTextBox.Text == "Theme")
            {
                themeTextBox.Text = "";
                themeTextBox.ForeColor = Color.Black;
            }
        }

        private void themeTextBox_Leave(object sender, EventArgs e)
        {
            if (themeTextBox.Text == "")
            {
                themeTextBox.Text = "Theme";
                themeTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
