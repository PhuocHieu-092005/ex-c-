namespace Full_EX
{
    partial class EX23
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btLeft (Nút sang trái) - [Slide 152]
            // 
            this.btLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btLeft.Location = new System.Drawing.Point(180, 250);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 40);
            this.btLeft.TabIndex = 0;
            this.btLeft.Text = "<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);

            // 
            // btRight (Nút sang phải) - [Slide 152]
            // 
            this.btRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btRight.Location = new System.Drawing.Point(240, 250);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 40);
            this.btRight.TabIndex = 1;
            this.btRight.Text = ">";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);

            // 
            // btFile (Nút tạo ảnh) - [Slide 152]
            // 
            this.btFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btFile.Location = new System.Drawing.Point(350, 250);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 40);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);

            // 
            // EX23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Name = "EX23";
            this.Text = "Simple Game"; // Tiêu đề Form [Slide 152]
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}