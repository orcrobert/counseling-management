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
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateFilterActivityLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterByDateButton = new System.Windows.Forms.Button();
            this.idColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.nameColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.classColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.motiveColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.appointmentsColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(1482, 669);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.subjectDatabaseToolStripMenuItem,
            this.appointmentDatabaseToolStripMenuItem,
            this.parentDatabaseToolStripMenuItem,
            this.teacherDatabaseToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exportPDFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 27);
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
            this.subjectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.subjectDatabaseToolStripMenuItem.Text = "Students";
            this.subjectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.subjectDatabaseToolStripMenuItem_Click);
            // 
            // appointmentDatabaseToolStripMenuItem
            // 
            this.appointmentDatabaseToolStripMenuItem.Name = "appointmentDatabaseToolStripMenuItem";
            this.appointmentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.appointmentDatabaseToolStripMenuItem.Text = "Appointments";
            this.appointmentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.appointmentDatabaseToolStripMenuItem_Click);
            // 
            // parentDatabaseToolStripMenuItem
            // 
            this.parentDatabaseToolStripMenuItem.Name = "parentDatabaseToolStripMenuItem";
            this.parentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.parentDatabaseToolStripMenuItem.Text = "Parents";
            this.parentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.parentDatabaseToolStripMenuItem_Click);
            // 
            // teacherDatabaseToolStripMenuItem
            // 
            this.teacherDatabaseToolStripMenuItem.Name = "teacherDatabaseToolStripMenuItem";
            this.teacherDatabaseToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.teacherDatabaseToolStripMenuItem.Text = "Teachers";
            this.teacherDatabaseToolStripMenuItem.Click += new System.EventHandler(this.teacherDatabaseToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.removeRowToolStripMenuItem,
            this.editRowButton});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addRowToolStripMenuItem.Text = "Add Row";
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // removeRowToolStripMenuItem
            // 
            this.removeRowToolStripMenuItem.Name = "removeRowToolStripMenuItem";
            this.removeRowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeRowToolStripMenuItem.Text = "Remove Row";
            this.removeRowToolStripMenuItem.Click += new System.EventHandler(this.removeRowToolStripMenuItem_Click);
            // 
            // editRowButton
            // 
            this.editRowButton.Name = "editRowButton";
            this.editRowButton.Size = new System.Drawing.Size(143, 22);
            this.editRowButton.Text = "Edit Row";
            this.editRowButton.Click += new System.EventHandler(this.editRowButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.dateFilterActivityLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1482, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "Clear Filters / Refresh";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // dateFilterActivityLabel
            // 
            this.dateFilterActivityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateFilterActivityLabel.Name = "dateFilterActivityLabel";
            this.dateFilterActivityLabel.Size = new System.Drawing.Size(109, 17);
            this.dateFilterActivityLabel.Text = "(inactive date filter)";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(984, 1);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 4;
            this.startDatePicker.Value = new System.DateTime(2024, 9, 24, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(1190, 1);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 5;
            // 
            // filterByDateButton
            // 
            this.filterByDateButton.Location = new System.Drawing.Point(1395, 0);
            this.filterByDateButton.Name = "filterByDateButton";
            this.filterByDateButton.Size = new System.Drawing.Size(75, 23);
            this.filterByDateButton.TabIndex = 6;
            this.filterByDateButton.Text = "Filter";
            this.filterByDateButton.UseVisualStyleBackColor = true;
            this.filterByDateButton.Click += new System.EventHandler(this.filterByDateButton_Click);
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
            // exportPDFToolStripMenuItem
            // 
            this.exportPDFToolStripMenuItem.Name = "exportPDFToolStripMenuItem";
            this.exportPDFToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.exportPDFToolStripMenuItem.Text = "Export PDF";
            this.exportPDFToolStripMenuItem.Click += new System.EventHandler(this.exportPDFToolStripMenuItem_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 721);
            this.Controls.Add(this.filterByDateButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.Text = "View Database";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button filterByDateButton;
        private System.Windows.Forms.ToolStripStatusLabel dateFilterActivityLabel;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRowButton;
        private System.Windows.Forms.ToolStripMenuItem exportPDFToolStripMenuItem;
    }
}