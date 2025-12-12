using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX20 : Form
    {
        public EX20()
        {
            InitializeComponent();
        }

        private void EX20_Load(object sender, EventArgs e)
        {
            // Thêm vài dòng dữ liệu mẫu cho đẹp
            dgvEmployee.Rows.Add("53418", "Trần Tiến", "20", true);
            dgvEmployee.Rows.Add("53416", "Nguyễn Cường", "25", false);
            dgvEmployee.Rows.Add("53417", "Nguyễn Hào", "23", true);
        }

        // [Slide 136] Xử lý nút THÊM
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô nhập và thêm dòng mới vào bảng
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked); //
        }

        // [Slide 137] Xử lý nút XÓA
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không (để tránh lỗi)
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex; // Lấy chỉ số dòng đang chọn
                dgvEmployee.Rows.RemoveAt(idx);             // Xóa dòng đó đi
            }
        }

        // [Slide 137] Sự kiện khi CLICK VÀO 1 DÒNG -> Đẩy dữ liệu ngược lại ô nhập
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex; // Lấy dòng vừa click vào

            // Kiểm tra index hợp lệ (vì DataGridView hay có dòng trống cuối cùng)
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1) // -1 vì dòng cuối là dòng chờ (new row)
            {
                // Lấy dữ liệu từng cột (Cells) đổ vào TextBox
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();      //
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();    //
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();     //

                // Lấy giá trị cột giới tính (ép kiểu string rồi parse sang bool)
                string genderVal = dgvEmployee.Rows[idx].Cells[3].Value.ToString();
                ckGender.Checked = bool.Parse(genderVal);                         //
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}