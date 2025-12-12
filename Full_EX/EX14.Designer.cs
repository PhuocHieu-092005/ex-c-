namespace Full_EX
{
    partial class EX14
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();

            // 
            // tbName (Nhập tên)
            // 
            this.tbName.Location = new System.Drawing.Point(30, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(320, 27);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Nguyễn Văn A";

            // 
            // gbGender (Nhóm Giới tính)
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(30, 60);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(320, 80);
            this.gbGender.TabIndex = 1;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";

            // 
            // rbMale (Nam) - [Slide 103, 105]
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true; // Mặc định chọn Nam
            this.rbMale.Location = new System.Drawing.Point(50, 35);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;

            // 
            // rbFemale (Nữ)
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(180, 35);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;

            // 
            // ckDiscount (Checkbox Giảm giá)
            // 
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(30, 160);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(91, 24);
            this.ckDiscount.TabIndex = 2;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            // Gán sự kiện khi tick vào ô giảm giá
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);

            // 
            // tbDiscount (Ô nhập số %)
            // 
            this.tbDiscount.Enabled = false; // Mặc định khóa lại
            this.tbDiscount.Location = new System.Drawing.Point(130, 158);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(220, 27);
            this.tbDiscount.TabIndex = 3;

            // 
            // tbResult (Kết quả)
            // 
            this.tbResult.Location = new System.Drawing.Point(30, 200);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(320, 100);
            this.tbResult.TabIndex = 4;

            // 
            // btRun (Nút Tính tiền)
            // 
            this.btRun.Location = new System.Drawing.Point(140, 320);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(100, 40);
            this.btRun.TabIndex = 5;
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);

            // 
            // btExit (Nút Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(250, 320);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 40);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // 
            // EX14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 380);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.tbName);
            this.Name = "EX14";
            this.Text = "Form1"; // Tên Form theo Slide 105
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
    }
}