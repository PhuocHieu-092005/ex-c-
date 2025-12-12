namespace Full_EX
{
    partial class EX20
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvEmployee (Bảng dữ liệu) - [Slide 135]
            // 
            this.dgvEmployee.AllowUserToAddRows = false; // Không cho user tự thêm dòng trống
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
            this.dgvEmployee.Size = new System.Drawing.Size(560, 200);
            this.dgvEmployee.TabIndex = 0;
            // Sự kiện khi chọn 1 dòng
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            // Cấu hình các cột (Header Text giống Slide 135)
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.Name = "colId";

            this.colName.HeaderText = "Tên nhân viên";
            this.colName.Name = "colName";
            this.colName.Width = 200;

            this.colAge.HeaderText = "Tuổi";
            this.colAge.Name = "colAge";
            this.colAge.Width = 60;

            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.Name = "colGender";
            this.colGender.Width = 110;

            // 
            // Các Label và TextBox bên dưới
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";

            this.tbId.Location = new System.Drawing.Point(100, 227);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 27);
            this.tbId.TabIndex = 2;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";

            this.tbName.Location = new System.Drawing.Point(100, 267);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(350, 27);
            this.tbName.TabIndex = 4;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuổi";

            this.tbAge.Location = new System.Drawing.Point(100, 307);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(150, 27);
            this.tbAge.TabIndex = 6;

            // Checkbox "Nam"
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(100, 350);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(63, 24);
            this.ckGender.TabIndex = 7;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;

            // 
            // Các Button
            // 
            this.btAddNew.Location = new System.Drawing.Point(230, 390);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(100, 40);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Location = new System.Drawing.Point(340, 390);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 40);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btExit.Location = new System.Drawing.Point(450, 390);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 40);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // EX20
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "EX20";
            this.Text = "DataGridView (Article 20)";
            this.Load += new System.EventHandler(this.EX20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
    }
}