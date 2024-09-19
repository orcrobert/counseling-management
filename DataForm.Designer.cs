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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.subjectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nameColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.classColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.motiveColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.appointmentsColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(1152, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.subjectDatabaseToolStripMenuItem,
            this.appointmentDatabaseToolStripMenuItem,
            this.parentDatabaseToolStripMenuItem,
            this.teacherDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Search";
            this.toolStripTextBox1.Enter += new System.EventHandler(this.toolStripTextBox1_Enter);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_Leave);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // subjectDatabaseToolStripMenuItem
            // 
            this.subjectDatabaseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.subjectDatabaseToolStripMenuItem.Name = "subjectDatabaseToolStripMenuItem";
            this.subjectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(109, 19);
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
            // parentDatabaseToolStripMenuItem
            // 
            this.parentDatabaseToolStripMenuItem.Name = "parentDatabaseToolStripMenuItem";
            this.parentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.parentDatabaseToolStripMenuItem.Text = "Parent Database";
            this.parentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.parentDatabaseToolStripMenuItem_Click);
            // 
            // teacherDatabaseToolStripMenuItem
            // 
            this.teacherDatabaseToolStripMenuItem.Name = "teacherDatabaseToolStripMenuItem";
            this.teacherDatabaseToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.teacherDatabaseToolStripMenuItem.Text = "Teacher Database";
            this.teacherDatabaseToolStripMenuItem.Click += new System.EventHandler(this.teacherDatabaseToolStripMenuItem_Click);
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
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 576);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource subjectsDataSetBindingSource;
        private SubjectsDataSet subjectsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn idColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn nameColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn classColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn motiveColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn appointmentsColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subjectDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem parentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherDatabaseToolStripMenuItem;
    }
}