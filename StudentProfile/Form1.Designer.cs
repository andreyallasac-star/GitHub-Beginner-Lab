namespace StudentProfile
{
    partial class Form1
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentName.Location = new System.Drawing.Point(76, 81);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(335, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name - GitHub Beginner Lab";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContact.Location = new System.Drawing.Point(76, 106);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(286, 25);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact Number: 09152191699";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(76, 130);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(372, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email Address: allasacandrei@gmail.com";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYearLevel.Location = new System.Drawing.Point(76, 155);
            this.lblYearLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(190, 25);
            this.lblYearLevel.TabIndex = 3;
            this.lblYearLevel.Text = "Year Level: 3rd Year";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentId.Location = new System.Drawing.Point(77, 180);
            this.lblStudentId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(242, 25);
            this.lblStudentId.TabIndex = 4;
            this.lblStudentId.Text = "Student ID - 02000654321";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProgram.Location = new System.Drawing.Point(77, 204);
            this.lblProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(154, 25);
            this.lblProgram.TabIndex = 5;
            this.lblProgram.Text = "Program: BSTM";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSection.Location = new System.Drawing.Point(77, 229);
            this.lblSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(159, 25);
            this.lblSection.TabIndex = 6;
            this.lblSection.Text = "Section: BT3102";
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrentYear.Location = new System.Drawing.Point(77, 254);
            this.lblCurrentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(206, 25);
            this.lblCurrentYear.TabIndex = 7;
            this.lblCurrentYear.Text = "Current Year: 1st Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 359);
            this.Controls.Add(this.lblCurrentYear);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblStudentName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblCurrentYear;
    }
}

