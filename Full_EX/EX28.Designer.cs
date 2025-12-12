namespace Full_EX
{
    partial class EX28
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500); // Tăng chiều cao chút cho rộng rãi
            this.Text = "Catch Egg Game - Final";
            this.Name = "EX28";

            // Đăng ký sự kiện
            this.Load += new System.EventHandler(this.EX28_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EX28_KeyDown);
        }

        #endregion
    }
}