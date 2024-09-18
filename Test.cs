using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace subjectmanager
{
    public partial class Test : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["subjectmanager.Properties.Settings.SubjectsConnectionString"].ConnectionString);
        public Test()
        {
            InitializeComponent();
            showData();
        }
        public void showData()
        {
            conn.Open();
            SqlDataAdapter show = new SqlDataAdapter(@"SELECT * from matricole", conn);
            DataTable table = new DataTable();
            show.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
