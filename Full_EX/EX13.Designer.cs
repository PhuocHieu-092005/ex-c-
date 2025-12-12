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
            cb_Faculty = new ComboBox();
            btOK = new Button();
            tbDisplay = new TextBox();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Location = new Point(26, 26);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(300, 28);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.SelectedValueChanged += cb_Faculty_SelectedValueChanged;
            // 
            // btOK
            // 
            btOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btOK.Location = new Point(340, 20);
            btOK.Name = "btOK";
            btOK.Size = new Size(70, 38);
            btOK.TabIndex = 1;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 12F);
            tbDisplay.Location = new Point(26, 80);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(384, 150);
            tbDisplay.TabIndex = 2;
            // 
            // EX13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 260);
            Controls.Add(tbDisplay);
            Controls.Add(btOK);
            Controls.Add(cb_Faculty);
            Name = "EX13";
            Text = "ComboBox Article 13";
            Load += EX13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}