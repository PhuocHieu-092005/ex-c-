namespace Full_EX
{
    partial class EX10
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            bt0 = new Button();
            tbDisplay = new TextBox();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btEquals = new Button();
            btDot = new Button();
            btMul = new Button();
            btPlus = new Button();
            SuspendLayout();
            // 
            // bt0
            // 
            bt0.BackColor = SystemColors.ButtonShadow;
            bt0.Font = new Font("Segoe UI", 20F);
            bt0.ForeColor = SystemColors.ControlText;
            bt0.Location = new Point(41, 96);
            bt0.Name = "bt0";
            bt0.Size = new Size(81, 68);
            bt0.TabIndex = 0;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = false;
            bt0.Click += bt0_Click;
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 20F);
            tbDisplay.Location = new Point(41, 12);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(378, 66);
            tbDisplay.TabIndex = 1;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt1
            // 
            bt1.BackColor = SystemColors.ButtonShadow;
            bt1.Font = new Font("Segoe UI", 20F);
            bt1.ForeColor = SystemColors.ControlText;
            bt1.Location = new Point(140, 96);
            bt1.Name = "bt1";
            bt1.Size = new Size(81, 68);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.BackColor = SystemColors.ButtonShadow;
            bt2.Font = new Font("Segoe UI", 20F);
            bt2.ForeColor = SystemColors.ControlText;
            bt2.Location = new Point(240, 96);
            bt2.Name = "bt2";
            bt2.Size = new Size(81, 68);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.BackColor = SystemColors.ButtonShadow;
            bt3.Font = new Font("Segoe UI", 20F);
            bt3.ForeColor = SystemColors.ControlText;
            bt3.Location = new Point(338, 96);
            bt3.Name = "bt3";
            bt3.Size = new Size(81, 68);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // btEquals
            // 
            btEquals.BackColor = SystemColors.ButtonShadow;
            btEquals.Font = new Font("Segoe UI", 20F);
            btEquals.ForeColor = SystemColors.ControlText;
            btEquals.Location = new Point(338, 179);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(81, 68);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = false;
            btEquals.Click += btEquals_Click;
            // 
            // btDot
            // 
            btDot.BackColor = SystemColors.ButtonShadow;
            btDot.Font = new Font("Segoe UI", 20F);
            btDot.ForeColor = SystemColors.ControlText;
            btDot.Location = new Point(240, 179);
            btDot.Name = "btDot";
            btDot.Size = new Size(81, 68);
            btDot.TabIndex = 7;
            btDot.Text = ".";
            btDot.UseVisualStyleBackColor = false;
            btDot.Click += btDot_Click;
            // 
            // btMul
            // 
            btMul.BackColor = SystemColors.ButtonShadow;
            btMul.Font = new Font("Segoe UI", 20F);
            btMul.ForeColor = SystemColors.ControlText;
            btMul.Location = new Point(140, 179);
            btMul.Name = "btMul";
            btMul.Size = new Size(81, 68);
            btMul.TabIndex = 6;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = false;
            btMul.Click += btMul_Click;
            // 
            // btPlus
            // 
            btPlus.BackColor = SystemColors.ButtonShadow;
            btPlus.Font = new Font("Segoe UI", 20F);
            btPlus.ForeColor = SystemColors.ControlText;
            btPlus.Location = new Point(41, 179);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(81, 68);
            btPlus.TabIndex = 5;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = false;
            btPlus.Click += btPlus_Click;
            // 
            // EX10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 288);
            Controls.Add(btEquals);
            Controls.Add(btDot);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(tbDisplay);
            Controls.Add(bt0);
            Name = "EX10";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btPlus;
    }
}