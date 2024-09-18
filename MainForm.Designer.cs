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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewDataFormButton
            // 
            this.viewDataFormButton.Location = new System.Drawing.Point(50, 82);
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
            this.addSubjectButton.Location = new System.Drawing.Point(414, 82);
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
            this.viewStatisticsFormButton.Location = new System.Drawing.Point(50, 155);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(50, 417);
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
            this.deleteSubjectButton.Location = new System.Drawing.Point(414, 155);
            this.deleteSubjectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(276, 54);
            this.deleteSubjectButton.TabIndex = 5;
            this.deleteSubjectButton.Text = "Delete Subject";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit Database";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 156);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewDataFormButton;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Button viewStatisticsFormButton;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button deleteSubjectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}