using System;
using System.Collections.Generic; // Cần dùng thư viện này cho List<>
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX21 : Form
    {
        // Khai báo List quản lý nhân viên [Slide 142]
        List<Employee> lst;

        public EX21()
        {
            InitializeComponent();
        }

        // [Slide 141] Hàm tạo dữ liệu giả
        public List<Employee> GetData()
        {
            List<Employee> list = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            em.Gender = true; // Nam
            list.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = false; // Nữ
            list.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hào";
            em.Age = 23;
            em.Gender = true;
            list.Add(em);

            return list;
        }

        // [Slide 142] Load Form: Đổ dữ liệu từ List vào DataGridView
        private void EX21_Load(object sender, EventArgs e)
        {
            lst = GetData(); // Lấy dữ liệu

            // Duyệt danh sách và thêm từng dòng vào bảng
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // [Slide 143] Thêm nhân viên
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // 1. Tạo đối tượng mới và thêm vào List (Quản lý ngầm)
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            // Parse tuổi an toàn (tránh lỗi nếu để trống)
            int age = 0;
            int.TryParse(tbAge.Text, out age);
            em.Age = age;
            em.Gender = ckGender.Checked;

            lst.Add(em); //

            // 2. Thêm hiển thị lên DataGridView (Giao diện)
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked); //
        }

        // [Slide 144] Xóa nhân viên
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa trong List trước
                lst.RemoveAt(idx); //

                // Xóa trên giao diện sau
                dgvEmployee.Rows.RemoveAt(idx); //
            }
        }

        // [Slide 144] Click vào dòng -> Đổ dữ liệu về TextBox
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            // Kiểm tra index hợp lệ để tránh lỗi
            if (idx >= 0 && idx < dgvEmployee.Rows.Count) // Bỏ -1 nếu tắt AllowUserToAddRows
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                string genderVal = dgvEmployee.Rows[idx].Cells[3].Value.ToString();
                ckGender.Checked = bool.Parse(genderVal);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}