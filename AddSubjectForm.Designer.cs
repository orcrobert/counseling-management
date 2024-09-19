namespace subjectmanager
{
    partial class AddSubjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.motiveTextBox = new System.Windows.Forms.TextBox();
            this.noOfAppointmentsTextBox = new System.Windows.Forms.TextBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.parentRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Appointments";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 170);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(208, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(333, 207);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(208, 27);
            this.classTextBox.TabIndex = 5;
            // 
            // motiveTextBox
            // 
            this.motiveTextBox.Location = new System.Drawing.Point(333, 243);
            this.motiveTextBox.Name = "motiveTextBox";
            this.motiveTextBox.Size = new System.Drawing.Size(208, 27);
            this.motiveTextBox.TabIndex = 6;
            // 
            // noOfAppointmentsTextBox
            // 
            this.noOfAppointmentsTextBox.Location = new System.Drawing.Point(333, 278);
            this.noOfAppointmentsTextBox.Name = "noOfAppointmentsTextBox";
            this.noOfAppointmentsTextBox.Size = new System.Drawing.Size(208, 27);
            this.noOfAppointmentsTextBox.TabIndex = 7;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(145, 372);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(186, 37);
            this.addSubjectButton.TabIndex = 8;
            this.addSubjectButton.Text = "Add to Database";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Checked = true;
            this.studentRadio.Location = new System.Drawing.Point(126, 93);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(80, 24);
            this.studentRadio.TabIndex = 9;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.CheckedChanged += new System.EventHandler(this.studentRadio_CheckedChanged);
            this.studentRadio.Click += new System.EventHandler(this.studentRadio_Click);
            // 
            // parentRadio
            // 
            this.parentRadio.AutoSize = true;
            this.parentRadio.Location = new System.Drawing.Point(293, 93);
            this.parentRadio.Name = "parentRadio";
            this.parentRadio.Size = new System.Drawing.Size(72, 24);
            this.parentRadio.TabIndex = 10;
            this.parentRadio.Text = "Parent";
            this.parentRadio.UseVisualStyleBackColor = true;
            this.parentRadio.CheckedChanged += new System.EventHandler(this.parentRadio_CheckedChanged);
            this.parentRadio.Click += new System.EventHandler(this.parentRadio_Click);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Location = new System.Drawing.Point(459, 93);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(80, 24);
            this.teacherRadio.TabIndex = 11;
            this.teacherRadio.Text = "Teacher";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.CheckedChanged += new System.EventHandler(this.teacherRadio_CheckedChanged);
            this.teacherRadio.Click += new System.EventHandler(this.teacherRadio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teacherRadio);
            this.Controls.Add(this.parentRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.noOfAppointmentsTextBox);
            this.Controls.Add(this.motiveTextBox);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox motiveTextBox;
        private System.Windows.Forms.TextBox noOfAppointmentsTextBox;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.RadioButton parentRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.Button button1;
    }
}