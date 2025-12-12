using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Full_EX
{
    public partial class EX16 : Form
    {
        // Biến đếm số lượng sinh viên (1, 2, 3...)
        int studentCount = 0;

        public EX16()
        {
            InitializeComponent();
        }

        private void EX16_Load(object sender, EventArgs e)
        {
            // Mặc định chọn khoa đầu tiên để đỡ bị trống
            if (cbFaculty.Items.Count > 0)
                cbFaculty.SelectedIndex = 0;
        }

        // Xử lý nút THÊM [Slide 112]
        private void btAdd_Click(object sender, EventArgs e)
        {
            // 1. Tăng số thứ tự
            studentCount++;

            // 2. Lấy thông tin
            string name = tbName.Text;
            string dob = dtpDob.Value.ToString("dd/MM/yyyy");
            string faculty = cbFaculty.SelectedItem.ToString();

            string gender = "Nữ";
            if (rbMale.Checked)
            {
                gender = "Nam";
            }

            // 3. Tạo chuỗi kết quả (Định dạng giống Slide 112)
            // Ví dụ: 
            // 1. Nguyễn Văn A
            //    -Giới tính: Nam
            //    -Ngày Sinh: ...
            string info = studentCount + ". " + name + "\r\n" +
                          "   -Giới tính: " + gender + "\r\n" +
                          "   -Ngày Sinh: " + dob + "\r\n" +
                          "   -Khoa: " + faculty + "\r\n\r\n";

            // 4. Thêm vào ô trạng thái
            tbStatus.Text += info;

            // 5. (Tùy chọn) Xóa tên để nhập người tiếp theo cho nhanh
            tbName.Clear();
            tbName.Focus();
        }

        // Xử lý nút THOÁT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}