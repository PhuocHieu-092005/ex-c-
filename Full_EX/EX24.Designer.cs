namespace Full_EX
{
    partial class EX24
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // 
            // lblDisplay (Hiện số giây) - [Slide 158]
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblDisplay.Location = new System.Drawing.Point(80, 30);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(250, 106);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "00:00"; // Giá trị ban đầu

            // 
            // btStart (Nút Bắt đầu)
            // 
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btStart.Location = new System.Drawing.Point(60, 160);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 40);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);

            // 
            // btStop (Nút Dừng)
            // 
            this.btStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btStop.Location = new System.Drawing.Point(220, 160);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(100, 40);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);

            // 
            // tmStopwatch (Đồng hồ ngầm) - [Slide 158]
            // 
            // Sự kiện Tick: Chạy lặp đi lặp lại sau mỗi khoảng thời gian
            this.tmStopwatch.Tick += new System.EventHandler(this.tmStopwatch_Tick);

            // 
            // EX24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblDisplay);
            this.Name = "EX24";
            this.Text = "Timer Article";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer tmStopwatch;
    }
}