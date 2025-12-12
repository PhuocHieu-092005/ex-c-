using System;
using System.Drawing;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX23 : Form
    {
        // [Slide 153] Khai báo biến toàn cục
        // PictureBox được tạo bằng code chứ không kéo thả
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public EX23()
        {
            InitializeComponent();
        }

        // [Slide 153] Sự kiện tạo và hiển thị ảnh
        private void btFile_Click(object sender, EventArgs e)
        {
            // Cấu hình PictureBox
            pb.SizeMode = PictureBoxSizeMode.StretchImage; //
            pb.Size = new Size(100, 100);                  //
            pb.Location = new Point(x, y);                 //

            // QUAN TRỌNG: Thêm PictureBox vào Form thì mới hiện lên được
            this.Controls.Add(pb);                         //

            // --- ĐOẠN NÀY MÌNH NÂNG CẤP ĐỂ BẠN CHỌN ẢNH TRÊN MÁY BẠN ---
            // (Code trong slide là: pb.ImageLocation = @"d:\abc.jpg"; sẽ dễ lỗi nếu không có file)
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = dlg.FileName;
            }
        }

        // [Slide 154] Di chuyển sang Trái
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; // Giảm tọa độ X
            pb.Location = new Point(x, y); // Cập nhật vị trí mới
        }

        // [Slide 154] Di chuyển sang Phải
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; // Tăng tọa độ X
            pb.Location = new Point(x, y); // Cập nhật vị trí mới
        }
    }
}