namespace assignment_forms_sample_GUI
{
    partial class frmUpdateClassInfo
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
            this.lblUpdateClassInfo = new System.Windows.Forms.Label();
            this.btnDeleteExistingClassInfo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateExistingClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateClassInfo
            // 
            this.lblUpdateClassInfo.AutoSize = true;
            this.lblUpdateClassInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateClassInfo.ForeColor = System.Drawing.Color.Green;
            this.lblUpdateClassInfo.Location = new System.Drawing.Point(228, 44);
            this.lblUpdateClassInfo.Name = "lblUpdateClassInfo";
            this.lblUpdateClassInfo.Size = new System.Drawing.Size(348, 37);
            this.lblUpdateClassInfo.TabIndex = 8;
            this.lblUpdateClassInfo.Text = "Update Your Class Info Here";
            this.lblUpdateClassInfo.Click += new System.EventHandler(this.lblUpdateClassInfo_Click);
            // 
            // btnDeleteExistingClassInfo
            // 
            this.btnDeleteExistingClassInfo.BackColor = System.Drawing.Color.White;
            this.btnDeleteExistingClassInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteExistingClassInfo.Location = new System.Drawing.Point(225, 234);
            this.btnDeleteExistingClassInfo.Name = "btnDeleteExistingClassInfo";
            this.btnDeleteExistingClassInfo.Size = new System.Drawing.Size(351, 43);
            this.btnDeleteExistingClassInfo.TabIndex = 9;
            this.btnDeleteExistingClassInfo.Text = "Delete Existing Class Information";
            this.btnDeleteExistingClassInfo.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(271, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(259, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateExistingClass
            // 
            this.btnUpdateExistingClass.BackColor = System.Drawing.Color.White;
            this.btnUpdateExistingClass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateExistingClass.Location = new System.Drawing.Point(225, 132);
            this.btnUpdateExistingClass.Name = "btnUpdateExistingClass";
            this.btnUpdateExistingClass.Size = new System.Drawing.Size(351, 43);
            this.btnUpdateExistingClass.TabIndex = 11;
            this.btnUpdateExistingClass.Text = "Update Existing Class Information";
            this.btnUpdateExistingClass.UseVisualStyleBackColor = false;
            // 
            // frmUpdateClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateExistingClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteExistingClassInfo);
            this.Controls.Add(this.lblUpdateClassInfo);
            this.Name = "frmUpdateClassInfo";
            this.Text = "UpdateClassInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUpdateClassInfo;
        private Button btnDeleteExistingClassInfo;
        private Button btnCancel;
        private Button btnUpdateExistingClass;
    }
}