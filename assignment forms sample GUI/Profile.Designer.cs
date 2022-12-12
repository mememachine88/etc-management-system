namespace assignment_forms_sample_GUI
{
    partial class frmProfile
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
            this.lblUpdateProfile = new System.Windows.Forms.Label();
            this.lblViewUsername = new System.Windows.Forms.Label();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblViewEmail = new System.Windows.Forms.Label();
            this.lblTelephoneNum = new System.Windows.Forms.Label();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateProfile
            // 
            this.lblUpdateProfile.AutoSize = true;
            this.lblUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUpdateProfile.Location = new System.Drawing.Point(235, 9);
            this.lblUpdateProfile.Name = "lblUpdateProfile";
            this.lblUpdateProfile.Size = new System.Drawing.Size(311, 37);
            this.lblUpdateProfile.TabIndex = 7;
            this.lblUpdateProfile.Text = "Update Your Profile Here";
            // 
            // lblViewUsername
            // 
            this.lblViewUsername.AutoSize = true;
            this.lblViewUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewUsername.ForeColor = System.Drawing.Color.Green;
            this.lblViewUsername.Location = new System.Drawing.Point(96, 97);
            this.lblViewUsername.Name = "lblViewUsername";
            this.lblViewUsername.Size = new System.Drawing.Size(111, 30);
            this.lblViewUsername.TabIndex = 11;
            this.lblViewUsername.Text = "Username:";
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewName.ForeColor = System.Drawing.Color.Green;
            this.lblViewName.Location = new System.Drawing.Point(133, 149);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(74, 30);
            this.lblViewName.TabIndex = 12;
            this.lblViewName.Text = "Name:";
            // 
            // lblViewEmail
            // 
            this.lblViewEmail.AutoSize = true;
            this.lblViewEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewEmail.ForeColor = System.Drawing.Color.Green;
            this.lblViewEmail.Location = new System.Drawing.Point(139, 200);
            this.lblViewEmail.Name = "lblViewEmail";
            this.lblViewEmail.Size = new System.Drawing.Size(68, 30);
            this.lblViewEmail.TabIndex = 13;
            this.lblViewEmail.Text = "Email:";
            // 
            // lblTelephoneNum
            // 
            this.lblTelephoneNum.AutoSize = true;
            this.lblTelephoneNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelephoneNum.ForeColor = System.Drawing.Color.Green;
            this.lblTelephoneNum.Location = new System.Drawing.Point(12, 261);
            this.lblTelephoneNum.Name = "lblTelephoneNum";
            this.lblTelephoneNum.Size = new System.Drawing.Size(195, 30);
            this.lblTelephoneNum.TabIndex = 14;
            this.lblTelephoneNum.Text = "Telephone Number:";
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.BackColor = System.Drawing.Color.White;
            this.btnReturnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnHome.Location = new System.Drawing.Point(235, 365);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(183, 43);
            this.btnReturnHome.TabIndex = 15;
            this.btnReturnHome.Text = "Return To Home";
            this.btnReturnHome.UseVisualStyleBackColor = false;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Green;
            this.lblUsername.Location = new System.Drawing.Point(213, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(171, 30);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "(Username here)";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(213, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 30);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "(Full Name Here)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Green;
            this.lblEmail.Location = new System.Drawing.Point(222, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 30);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "(Email Here)";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelephone.ForeColor = System.Drawing.Color.Green;
            this.lblTelephone.Location = new System.Drawing.Point(213, 261);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(176, 30);
            this.lblTelephone.TabIndex = 19;
            this.lblTelephone.Text = "(Telephone Here)";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProfile.Location = new System.Drawing.Point(463, 365);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(155, 43);
            this.btnUpdateProfile.TabIndex = 20;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.lblTelephoneNum);
            this.Controls.Add(this.lblViewEmail);
            this.Controls.Add(this.lblViewName);
            this.Controls.Add(this.lblViewUsername);
            this.Controls.Add(this.lblUpdateProfile);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUpdateProfile;
        private Label lblViewUsername;
        private Label lblViewName;
        private Label lblViewEmail;
        private Label lblTelephoneNum;
        private Button btnReturnHome;
        private Label lblUsername;
        private Label lblName;
        private Label lblEmail;
        private Label lblTelephone;
        private Button btnUpdateProfile;
    }
}