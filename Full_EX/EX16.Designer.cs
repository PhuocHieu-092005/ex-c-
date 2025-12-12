namespace Full_EX
{
    partial class EX16
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();

            // label1 (Họ và tên)
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";

            // tbName
            this.tbName.Location = new System.Drawing.Point(130, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 27);
            this.tbName.TabIndex = 1;

            // label2 (Ngày sinh)
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh";

            // dtpDob (DateTimePicker)
            this.dtpDob.CustomFormat = "dd/MM/yyyy";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(130, 65);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(250, 27);
            this.dtpDob.TabIndex = 3;

            // gbGender (Giới tính)
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(130, 100);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(250, 70);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Giới tính";

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(40, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(150, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(50, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;

            // label3 (Khoa)
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khoa";

            // cbFaculty (ComboBox)
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kế toán",
            "Cơ khí",
            "Điện",
            "Hóa"});
            this.cbFaculty.Location = new System.Drawing.Point(130, 187);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(250, 28);
            this.cbFaculty.TabIndex = 6;

            // label4 (Trạng thái)
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";

            // tbStatus (Dùng TextBox Multiline để hiện danh sách giống Slide 112)
            this.tbStatus.Location = new System.Drawing.Point(130, 240);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatus.Size = new System.Drawing.Size(250, 150);
            this.tbStatus.TabIndex = 8;

            // btAdd (Nút Thêm)
            this.btAdd.Location = new System.Drawing.Point(130, 410);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 40);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);

            // btExit (Nút Thoát)
            this.btExit.Location = new System.Drawing.Point(280, 410);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 40);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // EX16 Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "EX16";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.EX16_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
    }
}