namespace Full_EX
{
    partial class EX25
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
            this.SuspendLayout();
            // 
            // EX25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400); // Kích thước cửa sổ game
            this.Name = "EX25";
            this.Text = "Bouncing Ball Game";
            this.Load += new System.EventHandler(this.EX25_Load); // Quan trọng: Sự kiện Load
            this.ResumeLayout(false);
        }

        #endregion
    }
}