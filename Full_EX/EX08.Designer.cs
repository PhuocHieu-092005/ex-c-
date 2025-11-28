namespace Full_EX
{
    partial class EX08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbSoX = new TextBox();
            btCong = new Button();
            label2 = new Label();
            btNhan = new Button();
            btThoat = new Button();
            label3 = new Label();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(147, 35);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(319, 27);
            tbSoX.TabIndex = 1;
            tbSoX.TextChanged += textBox1_TextChanged;
            tbSoX.KeyPress += tbSoX_KeyPress;
            // 
            // btCong
            // 
            btCong.Location = new Point(31, 230);
            btCong.Name = "btCong";
            btCong.Size = new Size(114, 43);
            btCong.TabIndex = 2;
            btCong.Text = "CỘNG";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 3;
            label2.Text = "Số y";
            // 
            // btNhan
            // 
            btNhan.Location = new Point(162, 230);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(114, 43);
            btNhan.TabIndex = 5;
            btNhan.Text = "NHÂN";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(352, 230);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(114, 43);
            btThoat.TabIndex = 6;
            btThoat.Text = "THOÁT";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(31, 155);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 7;
            label3.Text = "Kết Quả";
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(147, 94);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(319, 27);
            tbSoY.TabIndex = 4;
            tbSoY.TextChanged += tbSoY_TextChanged;
            tbSoY.KeyPress += tbSoY_KeyPress;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(147, 156);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(319, 27);
            tbKetQua.TabIndex = 8;
            tbKetQua.TextChanged += tbKetQua_TextChanged;
            // 
            // EX08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 324);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(tbSoY);
            Controls.Add(label2);
            Controls.Add(btCong);
            Controls.Add(tbSoX);
            Controls.Add(label1);
            Name = "EX08";
            Text = "Caculator";
            Load += EX08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSoX;
        private Button btCong;
        private Label label2;
        private Button btNhan;
        private Button btThoat;
        private Label label3;
        private TextBox tbSoY;
        private TextBox tbKetQua;
    }
}