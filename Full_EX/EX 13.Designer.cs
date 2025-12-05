namespace Full_EX
{
    partial class EX13
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // cb_Faculty
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(26, 26);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(300, 28);
            this.cb_Faculty.TabIndex = 0;
            // Slide 101 yêu cầu sự kiện SelectedValueChanged
            this.cb_Faculty.SelectedValueChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged);

            // btOK
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btOK.Location = new System.Drawing.Point(340, 20);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(70, 38);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);

            // tbDisplay
            this.tbDisplay.Location = new System.Drawing.Point(26, 80);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(384, 150);
            this.tbDisplay.TabIndex = 2;
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 12F);

            // EX13
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 260);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "EX13";
            this.Text = "ComboBox Article 13";
            this.Load += new System.EventHandler(this.EX13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}