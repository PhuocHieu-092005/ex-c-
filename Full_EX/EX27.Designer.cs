namespace Full_EX
{
    partial class EX27
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
            // EX27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Name = "EX27";
            this.Text = "Catch Egg - Basket Movement";

            // [Quan trọng] Đăng ký sự kiện Load và KeyDown
            this.Load += new System.EventHandler(this.EX27_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EX27_KeyDown);

            this.ResumeLayout(false);
        }

        #endregion
    }
}