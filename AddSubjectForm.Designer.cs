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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Appointments";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(538, 214);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(208, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(538, 251);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(208, 27);
            this.classTextBox.TabIndex = 5;
            // 
            // motiveTextBox
            // 
            this.motiveTextBox.Location = new System.Drawing.Point(538, 287);
            this.motiveTextBox.Name = "motiveTextBox";
            this.motiveTextBox.Size = new System.Drawing.Size(208, 27);
            this.motiveTextBox.TabIndex = 6;
            // 
            // noOfAppointmentsTextBox
            // 
            this.noOfAppointmentsTextBox.Location = new System.Drawing.Point(538, 322);
            this.noOfAppointmentsTextBox.Name = "noOfAppointmentsTextBox";
            this.noOfAppointmentsTextBox.Size = new System.Drawing.Size(208, 27);
            this.noOfAppointmentsTextBox.TabIndex = 7;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(473, 404);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(107, 37);
            this.addSubjectButton.TabIndex = 8;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 826);
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
    }
}