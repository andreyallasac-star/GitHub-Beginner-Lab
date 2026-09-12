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
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentName.Location = new System.Drawing.Point(57, 66);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(275, 20);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name - GitHub Beginner Lab";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContact.Location = new System.Drawing.Point(57, 86);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(232, 20);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact Number: 09152191699";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(57, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(299, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email Address: allasacandrei@gmail.com";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYearLevel.Location = new System.Drawing.Point(57, 126);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(157, 20);
            this.lblYearLevel.TabIndex = 3;
            this.lblYearLevel.Text = "Year Level: 2nd Year";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentId.Location = new System.Drawing.Point(58, 146);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(199, 20);
            this.lblStudentId.TabIndex = 4;
            this.lblStudentId.Text = "Student ID - 02000123456";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProgram.Location = new System.Drawing.Point(58, 166);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(113, 20);
            this.lblProgram.TabIndex = 5;
            this.lblProgram.Text = "Program: BSIT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 292);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblStudentName);
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
    }
}

