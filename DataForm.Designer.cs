namespace subjectmanager
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subjectsDataSet = new subjectmanager.SubjectsDataSet();
            this.subjectsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nameColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.classColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.motiveColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.appointmentsColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subjectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectsDataSet
            // 
            this.subjectsDataSet.DataSetName = "SubjectsDataSet";
            this.subjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsDataSetBindingSource
            // 
            this.subjectsDataSetBindingSource.DataSource = this.subjectsDataSet;
            this.subjectsDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.classColumn,
            this.motiveColumn,
            this.appointmentsColumn});
            this.dataGridView1.DataSource = this.subjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1152, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            this.idColumn.FilteringEnabled = false;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.FilteringEnabled = false;
            this.nameColumn.HeaderText = "name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // classColumn
            // 
            this.classColumn.DataPropertyName = "classOf";
            this.classColumn.FilteringEnabled = false;
            this.classColumn.HeaderText = "classOf";
            this.classColumn.Name = "classColumn";
            this.classColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // motiveColumn
            // 
            this.motiveColumn.DataPropertyName = "motive";
            this.motiveColumn.FilteringEnabled = false;
            this.motiveColumn.HeaderText = "motive";
            this.motiveColumn.Name = "motiveColumn";
            this.motiveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // appointmentsColumn
            // 
            this.appointmentsColumn.DataPropertyName = "noOfAppointments";
            this.appointmentsColumn.FilteringEnabled = false;
            this.appointmentsColumn.HeaderText = "noOfAppointments";
            this.appointmentsColumn.Name = "appointmentsColumn";
            this.appointmentsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(subjectmanager.Subject);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Show All";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.subjectDatabaseToolStripMenuItem,
            this.appointmentDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subjectDatabaseToolStripMenuItem
            // 
            this.subjectDatabaseToolStripMenuItem.Name = "subjectDatabaseToolStripMenuItem";
            this.subjectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.subjectDatabaseToolStripMenuItem.Text = "Subject Database";
            this.subjectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.subjectDatabaseToolStripMenuItem_Click);
            // 
            // appointmentDatabaseToolStripMenuItem
            // 
            this.appointmentDatabaseToolStripMenuItem.Name = "appointmentDatabaseToolStripMenuItem";
            this.appointmentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.appointmentDatabaseToolStripMenuItem.Text = "Appointment Database";
            this.appointmentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.appointmentDatabaseToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Search";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataForm";
            this.Text = "View Database";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource subjectsDataSetBindingSource;
        private SubjectsDataSet subjectsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn idColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn nameColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn classColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn motiveColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn appointmentsColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subjectDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}