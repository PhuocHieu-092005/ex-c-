using System;
using System.Drawing; // Cần thư viện này cho xử lý ảnh
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX19 : Form
    {
        public EX19()
        {
            InitializeComponent();
        }

        // [Slide 129] Sự kiện khi bấm nút Chọn ảnh
        private void btFile_Click(object sender, EventArgs e)
        {
            // 1. Chế độ hiển thị ảnh: Co dãn vừa khung
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2. Khởi tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image"; // Tiêu đề hộp thoại

            // Chỉ cho phép chọn file ảnh JPG
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            // 3. Nếu người dùng chọn file và bấm OK
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn ảnh vào PictureBox để hiển thị
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}