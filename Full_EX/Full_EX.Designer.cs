namespace Full_EX
{
    partial class Full_EX
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 25);
            button1.Name = "button1";
            button1.Size = new Size(125, 73);
            button1.TabIndex = 0;
            button1.Text = "EX01";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(182, 25);
            button2.Name = "button2";
            button2.Size = new Size(125, 73);
            button2.TabIndex = 1;
            button2.Text = "EX02";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Full_EX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 363);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Full_EX";
            Text = "Navigation";
            Load += this.Full_EX_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
