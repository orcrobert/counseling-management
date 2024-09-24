namespace subjectmanager
{
    partial class AddAppointmentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.parentRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.groupRadio = new System.Windows.Forms.RadioButton();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add to Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add appointment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(387, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // themeTextBox
            // 
            this.themeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.themeTextBox.Location = new System.Drawing.Point(193, 273);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(387, 26);
            this.themeTextBox.TabIndex = 12;
            this.themeTextBox.Text = "Theme";
            this.themeTextBox.Enter += new System.EventHandler(this.themeTextBox_Enter);
            this.themeTextBox.Leave += new System.EventHandler(this.themeTextBox_Leave);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(193, 184);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(387, 28);
            this.subjectsComboBox.TabIndex = 0;
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Location = new System.Drawing.Point(388, 332);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(145, 28);
            this.scheduleButton.TabIndex = 13;
            this.scheduleButton.Text = "Add to Calendar";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click_1);
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Checked = true;
            this.studentRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadio.Location = new System.Drawing.Point(187, 131);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(84, 24);
            this.studentRadio.TabIndex = 14;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.Click += new System.EventHandler(this.studentRadio_Click);
            // 
            // parentRadio
            // 
            this.parentRadio.AutoSize = true;
            this.parentRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentRadio.Location = new System.Drawing.Point(277, 131);
            this.parentRadio.Name = "parentRadio";
            this.parentRadio.Size = new System.Drawing.Size(74, 24);
            this.parentRadio.TabIndex = 15;
            this.parentRadio.Text = "Parent";
            this.parentRadio.UseVisualStyleBackColor = true;
            this.parentRadio.Click += new System.EventHandler(this.parentRadio_Click);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRadio.Location = new System.Drawing.Point(357, 131);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(85, 24);
            this.teacherRadio.TabIndex = 16;
            this.teacherRadio.Text = "Teacher";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.Click += new System.EventHandler(this.teacherRadio_Click);
            // 
            // groupRadio
            // 
            this.groupRadio.AutoSize = true;
            this.groupRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRadio.Location = new System.Drawing.Point(448, 131);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Size = new System.Drawing.Size(72, 24);
            this.groupRadio.TabIndex = 18;
            this.groupRadio.Text = "Group";
            this.groupRadio.UseVisualStyleBackColor = true;
            this.groupRadio.Click += new System.EventHandler(this.groupRadio_Click);
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRadio.Location = new System.Drawing.Point(526, 131);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(67, 24);
            this.otherRadio.TabIndex = 19;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = true;
            this.otherRadio.Click += new System.EventHandler(this.otherRadio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(193, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 26);
            this.textBox1.TabIndex = 20;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 481);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.otherRadio);
            this.Controls.Add(this.groupRadio);
            this.Controls.Add(this.teacherRadio);
            this.Controls.Add(this.parentRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectsComboBox);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton parentRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.RadioButton groupRadio;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.TextBox textBox1;
    }
}