namespace subjectmanager
{
    partial class MainForm
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
            this.viewDataFormButton = new System.Windows.Forms.Button();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.viewStatisticsFormButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewDataFormButton
            // 
            this.viewDataFormButton.Location = new System.Drawing.Point(405, 34);
            this.viewDataFormButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewDataFormButton.Name = "viewDataFormButton";
            this.viewDataFormButton.Size = new System.Drawing.Size(276, 54);
            this.viewDataFormButton.TabIndex = 0;
            this.viewDataFormButton.Text = "View Subject Database";
            this.viewDataFormButton.UseVisualStyleBackColor = true;
            this.viewDataFormButton.Click += new System.EventHandler(this.viewDataFormButton_Click);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(405, 115);
            this.addSubjectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(276, 54);
            this.addSubjectButton.TabIndex = 1;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // viewStatisticsFormButton
            // 
            this.viewStatisticsFormButton.Location = new System.Drawing.Point(405, 277);
            this.viewStatisticsFormButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewStatisticsFormButton.Name = "viewStatisticsFormButton";
            this.viewStatisticsFormButton.Size = new System.Drawing.Size(276, 54);
            this.viewStatisticsFormButton.TabIndex = 2;
            this.viewStatisticsFormButton.Text = "View Statistics";
            this.viewStatisticsFormButton.UseVisualStyleBackColor = true;
            this.viewStatisticsFormButton.Click += new System.EventHandler(this.viewStatisticsFormButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(405, 353);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(276, 54);
            this.addAppointmentButton.TabIndex = 4;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(405, 198);
            this.deleteSubjectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(276, 54);
            this.deleteSubjectButton.TabIndex = 5;
            this.deleteSubjectButton.Text = "Delete Subject";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 760);
            this.Controls.Add(this.deleteSubjectButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.viewStatisticsFormButton);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.viewDataFormButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewDataFormButton;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button viewStatisticsFormButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button deleteSubjectButton;
    }
}