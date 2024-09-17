using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace subjectmanager
{
    public partial class DataForm : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public DataForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridView();
            LoadData();
            ConfigureForm();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Robert\\source\\repos\\subjectmanager\\Subjects.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        private void InitializeDataGridView()
        {
            matricoleDataGridView = new DataGridView
            {
                Width = 1100,
                Height = 400,
                AutoGenerateColumns = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    Font = new Font("Verdana", 10, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Verdana", 10),
                    ForeColor = Color.Black,
                    BackColor = Color.LightGray,
                    SelectionBackColor = Color.DarkGray
                },
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.WhiteSmoke
                },
                GridColor = Color.LightGray,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle = BorderStyle.None,
            };
            matricoleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            matricoleDataGridView.Location = new Point((this.ClientSize.Width - matricoleDataGridView.Width) / 2, (this.ClientSize.Height - matricoleDataGridView.Height) / 2);

            this.Controls.Add(matricoleDataGridView);
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM matricole";
                adapter = new SqlDataAdapter(query, conn);
                dataTable = new DataTable();

                adapter.Fill(dataTable);

                matricoleDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ConfigureForm()
        {
            this.Text = "Subject Manager - Data Overview";
            this.Size = new Size(1200, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            Label titleLabel = new Label
            {
                Text = "Subject List",
                Font = new Font("Verdana", 16, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(titleLabel);

            matricoleDataGridView.Location = new Point(20, 60);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}