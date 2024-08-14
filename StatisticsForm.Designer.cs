namespace subjectmanager
{
    partial class StatisticsForm
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
            this.numberOfSubjectsLabel = new System.Windows.Forms.Label();
            this.completedAppointmentsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfCounseledLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Completed Appointments";
            // 
            // numberOfSubjectsLabel
            // 
            this.numberOfSubjectsLabel.AutoSize = true;
            this.numberOfSubjectsLabel.Location = new System.Drawing.Point(457, 120);
            this.numberOfSubjectsLabel.Name = "numberOfSubjectsLabel";
            this.numberOfSubjectsLabel.Size = new System.Drawing.Size(0, 20);
            this.numberOfSubjectsLabel.TabIndex = 2;
            // 
            // completedAppointmentsLabel
            // 
            this.completedAppointmentsLabel.AutoSize = true;
            this.completedAppointmentsLabel.Location = new System.Drawing.Point(457, 183);
            this.completedAppointmentsLabel.Name = "completedAppointmentsLabel";
            this.completedAppointmentsLabel.Size = new System.Drawing.Size(0, 20);
            this.completedAppointmentsLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of counseled";
            // 
            // numberOfCounseledLabel
            // 
            this.numberOfCounseledLabel.AutoSize = true;
            this.numberOfCounseledLabel.Location = new System.Drawing.Point(457, 240);
            this.numberOfCounseledLabel.Name = "numberOfCounseledLabel";
            this.numberOfCounseledLabel.Size = new System.Drawing.Size(0, 20);
            this.numberOfCounseledLabel.TabIndex = 5;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 868);
            this.Controls.Add(this.numberOfCounseledLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.completedAppointmentsLabel);
            this.Controls.Add(this.numberOfSubjectsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfSubjectsLabel;
        private System.Windows.Forms.Label completedAppointmentsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberOfCounseledLabel;
    }
}