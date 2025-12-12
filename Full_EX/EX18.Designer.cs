namespace Full_EX
{
    partial class EX18
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
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Text = "Danh sách bài hát (DataSource)";
            this.label1.Size = new System.Drawing.Size(126, 20);

            // lbSong (Dùng DataSource)
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(20, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(250, 264);
            this.lbSong.TabIndex = 0;

            // btSelect (Nút >)
            this.btSelect.Location = new System.Drawing.Point(285, 150);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 40);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 20);
            this.label2.Name = "label2";
            this.label2.Text = "Danh sách yêu thích";
            this.label2.Size = new System.Drawing.Size(182, 20);

            // lbFavorite
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(350, 50);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(250, 264);
            this.lbFavorite.TabIndex = 2;

            // EX18
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.label1);
            this.Name = "EX18";
            this.Text = "Music Selector (Article 18)";
            this.Load += new System.EventHandler(this.EX18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}