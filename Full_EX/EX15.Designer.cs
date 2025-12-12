namespace Full_EX
{
    partial class EX15
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // label1 (Chữ "Date")
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";

            // 
            // dtpDate (Ô chọn ngày tháng) - [Slide 110]
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short; // Hiển thị kiểu ngắn
            this.dtpDate.Location = new System.Drawing.Point(100, 35);
            this.dtpDate.Name = "dtpDate"; // Tên biến trong code Slide 110
            this.dtpDate.Size = new System.Drawing.Size(200, 34);
            this.dtpDate.TabIndex = 1;
            // Sự kiện khi thay đổi ngày
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);

            // 
            // btOK (Nút bấm)
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btOK.Location = new System.Drawing.Point(200, 100);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 40);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // Sự kiện bấm nút
            this.btOK.Click += new System.EventHandler(this.btOK_Click);

            // 
            // EX15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "EX15";
            this.Text = "DateTimePicker"; // Tiêu đề ban đầu
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label1;
    }
}