namespace assignment_forms_sample_GUI
{
    partial class Popup
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
            this.lblPopup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPopup
            // 
            this.lblPopup.AutoSize = true;
            this.lblPopup.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPopup.ForeColor = System.Drawing.Color.Green;
            this.lblPopup.Location = new System.Drawing.Point(330, 202);
            this.lblPopup.Name = "lblPopup";
            this.lblPopup.Size = new System.Drawing.Size(176, 37);
            this.lblPopup.TabIndex = 8;
            this.lblPopup.Text = "Add text here";
            this.lblPopup.Click += new System.EventHandler(this.lblPopup_Click);
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPopup);
            this.Name = "Popup";
            this.Text = "Popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPopup;
    }
}