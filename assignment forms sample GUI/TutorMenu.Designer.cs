namespace assignment_forms_sample_GUI
{
    partial class TutorMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddClassInfo = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewStudentList = new System.Windows.Forms.Button();
            this.btnUpdateClassInfo = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddClassInfo
            // 
            this.btnAddClassInfo.BackColor = System.Drawing.Color.White;
            this.btnAddClassInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddClassInfo.Location = new System.Drawing.Point(238, 123);
            this.btnAddClassInfo.Name = "btnAddClassInfo";
            this.btnAddClassInfo.Size = new System.Drawing.Size(259, 43);
            this.btnAddClassInfo.TabIndex = 2;
            this.btnAddClassInfo.Text = "Add Class Information ";
            this.btnAddClassInfo.UseVisualStyleBackColor = false;
            this.btnAddClassInfo.Click += new System.EventHandler(this.btnAddClassInfo_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProfile.Location = new System.Drawing.Point(238, 346);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(259, 43);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnViewStudentList
            // 
            this.btnViewStudentList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewStudentList.Location = new System.Drawing.Point(238, 266);
            this.btnViewStudentList.Name = "btnViewStudentList";
            this.btnViewStudentList.Size = new System.Drawing.Size(259, 43);
            this.btnViewStudentList.TabIndex = 4;
            this.btnViewStudentList.Text = "View Student List";
            this.btnViewStudentList.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClassInfo
            // 
            this.btnUpdateClassInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateClassInfo.Location = new System.Drawing.Point(238, 190);
            this.btnUpdateClassInfo.Name = "btnUpdateClassInfo";
            this.btnUpdateClassInfo.Size = new System.Drawing.Size(259, 43);
            this.btnUpdateClassInfo.TabIndex = 5;
            this.btnUpdateClassInfo.Text = "Update Class Information";
            this.btnUpdateClassInfo.UseVisualStyleBackColor = true;
            this.btnUpdateClassInfo.Click += new System.EventHandler(this.btnUpdateClassInfo_Click);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(224, 43);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(306, 37);
            this.lblWelcomeMessage.TabIndex = 6;
            this.lblWelcomeMessage.Text = "Welcome ! (Tutor Name)";
            this.lblWelcomeMessage.Click += new System.EventHandler(this.lblWelcomeMessage_Click);
            // 
            // TutorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.btnUpdateClassInfo);
            this.Controls.Add(this.btnViewStudentList);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnAddClassInfo);
            this.Name = "TutorMenu";
            this.Text = "Tutor Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddClassInfo;
        private Button btnUpdateProfile;
        private Button btnViewStudentList;
        private Button btnUpdateClassInfo;
        private Label lblWelcomeMessage;
    }
}