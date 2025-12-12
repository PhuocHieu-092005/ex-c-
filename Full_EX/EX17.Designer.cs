namespace Full_EX
{
    partial class EX17
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
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label1 (Tiêu đề trái)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài hát";

            // 
            // lbSong (Danh sách trái - Nguồn)
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            // Nhập sẵn danh sách bài hát giống Slide 116
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt Pleiku",
            "Em Muốn Sống Bên Anh Trọn Đời",
            "H\'Zen Lên Rẫy",
            "Còn Thương Nhau Thì Về Buôn Mê Thuột",
            "Ly Cà Phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(20, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(250, 264);
            this.lbSong.TabIndex = 1;
            // Sự kiện Double Click
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);

            // 
            // label2 (Tiêu đề phải)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách bài hát ưa thích";

            // 
            // lbFavorite (Danh sách phải - Đích)
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 20;
            this.lbFavorite.Location = new System.Drawing.Point(350, 50);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(250, 264);
            this.lbFavorite.TabIndex = 3;
            // Sự kiện Double Click ngược lại (tự thêm cho hoàn thiện)
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);

            // 
            // btSelect (Nút >)
            // 
            this.btSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSelect.Location = new System.Drawing.Point(285, 80);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 40);
            this.btSelect.TabIndex = 4;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);

            // 
            // btSelectAll (Nút >>)
            // 
            this.btSelectAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSelectAll.Location = new System.Drawing.Point(285, 130);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(50, 40);
            this.btSelectAll.TabIndex = 5;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);

            // 
            // btDeselect (Nút <)
            // 
            this.btDeselect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDeselect.Location = new System.Drawing.Point(285, 180);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(50, 40);
            this.btDeselect.TabIndex = 6;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);

            // 
            // btDeselectAll (Nút <<)
            // 
            this.btDeselectAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDeselectAll.Location = new System.Drawing.Point(285, 230);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(50, 40);
            this.btDeselectAll.TabIndex = 7;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);

            // 
            // EX17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.label1);
            this.Name = "EX17";
            this.Text = "Music Selector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btDeselectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}