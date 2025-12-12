namespace Full_EX
{
    partial class EX19
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();

            // 
            // label1 (Mã nhân viên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";

            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(140, 27);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 27);
            this.tbId.TabIndex = 1;
            this.tbId.Text = "03152482001"; // Giá trị mẫu giống Slide 128

            // 
            // label2 (Tên nhân viên)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên";

            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(140, 67);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 27);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Nguyễn Văn Hùng";

            // 
            // label3 (Ảnh 3x4)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anh 3x4";

            // 
            // pbImage (Khung ảnh) - [Slide 125, 128]
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Viền khung
            this.pbImage.Location = new System.Drawing.Point(140, 110);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 200); // Kích thước chuẩn ảnh thẻ
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;

            // 
            // btFile (Nút Chọn ảnh) - [Slide 128]
            // 
            this.btFile.Location = new System.Drawing.Point(300, 110);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 40);
            this.btFile.TabIndex = 6;
            this.btFile.Text = "Chọn ảnh ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click); // Sự kiện chọn ảnh

            // 
            // EX19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 340);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "EX19";
            this.Text = "Quản lý nhân sự"; // Tiêu đề Slide 128
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
    }
}