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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.parentRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 166);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add individual appointment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add group of students appointment";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(524, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Appointment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(583, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of appointments";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // themeTextBox
            // 
            this.themeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.themeTextBox.Location = new System.Drawing.Point(12, 127);
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(300, 22);
            this.themeTextBox.TabIndex = 12;
            this.themeTextBox.Text = "Theme";
            this.themeTextBox.Enter += new System.EventHandler(this.themeTextBox_Enter);
            this.themeTextBox.Leave += new System.EventHandler(this.themeTextBox_Leave);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Location = new System.Drawing.Point(12, 72);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(300, 24);
            this.subjectsComboBox.TabIndex = 0;
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.Location = new System.Drawing.Point(167, 166);
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
            this.studentRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadio.Location = new System.Drawing.Point(38, 42);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(70, 20);
            this.studentRadio.TabIndex = 14;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.Click += new System.EventHandler(this.studentRadio_Click);
            // 
            // parentRadio
            // 
            this.parentRadio.AutoSize = true;
            this.parentRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentRadio.Location = new System.Drawing.Point(114, 42);
            this.parentRadio.Name = "parentRadio";
            this.parentRadio.Size = new System.Drawing.Size(64, 20);
            this.parentRadio.TabIndex = 15;
            this.parentRadio.Text = "Parent";
            this.parentRadio.UseVisualStyleBackColor = true;
            this.parentRadio.Click += new System.EventHandler(this.parentRadio_Click);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRadio.Location = new System.Drawing.Point(184, 44);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(76, 20);
            this.teacherRadio.TabIndex = 16;
            this.teacherRadio.Text = "Teacher";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.Click += new System.EventHandler(this.teacherRadio_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 481);
            this.Controls.Add(this.teacherRadio);
            this.Controls.Add(this.parentRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectsComboBox);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton parentRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
    }
}