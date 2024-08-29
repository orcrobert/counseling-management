using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace subjectmanager
{
    public partial class Test : Form
    {
        //private DataGridView matricoleDataGridView;
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public Test()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDatabaseConnection()
        {
            // Set up the SQL connection
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Robert\\source\\repos\\subjectmanager\\Subjects.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        private void InitializeDataGridView()
        {
            // Initialize and configure the DataGridView
            matricoleDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true, // Automatically generate columns based on the data source
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true
            };

            // Add the DataGridView to the form's controls
            this.Controls.Add(matricoleDataGridView);
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                // Define the SQL command and adapter
                string query = "SELECT * FROM matricole";
                adapter = new SqlDataAdapter(query, conn);
                dataTable = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
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

        private void Test_Load(object sender, EventArgs e)
        {
            // Load data when the form loads
            LoadData();
        }
    }
}
