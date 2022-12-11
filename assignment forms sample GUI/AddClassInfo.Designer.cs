namespace assignment_forms_sample_GUI
{
    partial class frmAddClassInfo



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
            this.btnAddClassInfo = new System.Windows.Forms.Button();
            this.lblAddClassInfo = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblClassDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblClassTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.radAm = new System.Windows.Forms.RadioButton();
            this.radPm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAddClassInfo
            // 
            this.btnAddClassInfo.BackColor = System.Drawing.Color.White;
            this.btnAddClassInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddClassInfo.Location = new System.Drawing.Point(175, 374);
            this.btnAddClassInfo.Name = "btnAddClassInfo";
            this.btnAddClassInfo.Size = new System.Drawing.Size(259, 43);
            this.btnAddClassInfo.TabIndex = 3;
            this.btnAddClassInfo.Text = "Add Class Information ";
            this.btnAddClassInfo.UseVisualStyleBackColor = false;
            // 
            // lblAddClassInfo
            // 
            this.lblAddClassInfo.AutoSize = true;
            this.lblAddClassInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddClassInfo.ForeColor = System.Drawing.Color.Green;
            this.lblAddClassInfo.Location = new System.Drawing.Point(256, 19);
            this.lblAddClassInfo.Name = "lblAddClassInfo";
            this.lblAddClassInfo.Size = new System.Drawing.Size(317, 37);
            this.lblAddClassInfo.TabIndex = 7;
            this.lblAddClassInfo.Text = "Add Your Class Info Here!";
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "English",
            "Chinese",
            "Malay",
            "Mathemathics",
            "Science",
            "History"});
            this.cmbSubject.Location = new System.Drawing.Point(323, 99);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(159, 38);
            this.cmbSubject.TabIndex = 9;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.Green;
            this.lblSubject.Location = new System.Drawing.Point(199, 99);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(86, 30);
            this.lblSubject.TabIndex = 10;
            this.lblSubject.Text = "Subject:";
            // 
            // lblClassDate
            // 
            this.lblClassDate.AutoSize = true;
            this.lblClassDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClassDate.ForeColor = System.Drawing.Color.Green;
            this.lblClassDate.Location = new System.Drawing.Point(222, 164);
            this.lblClassDate.Name = "lblClassDate";
            this.lblClassDate.Size = new System.Drawing.Size(62, 30);
            this.lblClassDate.TabIndex = 11;
            this.lblClassDate.Text = "Date:";
            this.lblClassDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(534, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 43);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(323, 164);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(127, 35);
            this.dtpDate.TabIndex = 18;
            // 
            // lblClassTime
            // 
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClassTime.ForeColor = System.Drawing.Color.Green;
            this.lblClassTime.Location = new System.Drawing.Point(222, 241);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new System.Drawing.Size(63, 30);
            this.lblClassTime.TabIndex = 19;
            this.lblClassTime.Text = "Time:";
            this.lblClassTime.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.Location = new System.Drawing.Point(323, 241);
            this.txtTime.MaxLength = 5;
            this.txtTime.Name = "txtTime";
            this.txtTime.PlaceholderText = "00:00";
            this.txtTime.Size = new System.Drawing.Size(111, 35);
            this.txtTime.TabIndex = 20;
            // 
            // radAm
            // 
            this.radAm.AutoSize = true;
            this.radAm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radAm.Location = new System.Drawing.Point(464, 242);
            this.radAm.Name = "radAm";
            this.radAm.Size = new System.Drawing.Size(64, 34);
            this.radAm.TabIndex = 21;
            this.radAm.TabStop = true;
            this.radAm.Text = "AM";
            this.radAm.UseVisualStyleBackColor = true;
            // 
            // radPm
            // 
            this.radPm.AutoSize = true;
            this.radPm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPm.Location = new System.Drawing.Point(534, 242);
            this.radPm.Name = "radPm";
            this.radPm.Size = new System.Drawing.Size(62, 34);
            this.radPm.TabIndex = 22;
            this.radPm.TabStop = true;
            this.radPm.Text = "PM";
            this.radPm.UseVisualStyleBackColor = true;
            // 
            // frmAddClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radPm);
            this.Controls.Add(this.radAm);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblClassTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblClassDate);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblAddClassInfo);
            this.Controls.Add(this.btnAddClassInfo);
            this.Name = "frmAddClassInfo";
            this.Text = "AddClassInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAddClassInfo;
        private Label lblAddClassInfo;
        private ComboBox cmbSubject;
        private Label lblSubject;
        private Label lblClassDate;
        private Button btnCancel;
        private DateTimePicker dtpDate;
        private Label lblClassTime;
        private TextBox txtTime;
        private RadioButton radAm;
        private RadioButton radPm;
    }
}