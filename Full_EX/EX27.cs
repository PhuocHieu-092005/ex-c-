using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Full_EX
{
    public partial class EX27 : Form
    {
        // [Slide 173] Khai báo đối tượng Giỏ và tọa độ
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 380; // Hạ thấp xuống đáy form (Slide để 500 có thể bị khuất nếu form nhỏ)
        int xDelta = 30;   // Tốc độ di chuyển mỗi lần bấm phím

        public EX27()
        {
            InitializeComponent();
        }

        // [Slide 174] Load Form: Tạo và hiển thị cái giỏ
        private void EX27_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;

            // Xử lý ảnh (dự phòng nếu thiếu ảnh)
            string pathBasket = "../../../Images/ro.jpg"; //

            if (File.Exists(pathBasket)) 
            {
                pbBasket.Image = Image.FromFile(pathBasket);
            }
            else
            {
                pbBasket.BackColor = Color.Blue; // Dùng ô màu xanh nếu chưa có ảnh
            }

            this.Controls.Add(pbBasket);
        }

        // [Slide 174] Sự kiện nhấn phím để di chuyển giỏ
        private void EX27_KeyDown(object sender, KeyEventArgs e)
        {
            // Mã phím: 39 là Mũi tên Phải, 37 là Mũi tên Trái (Slide 174)

            // 1. Nếu bấm sang PHẢI (Right Arrow) và chưa chạm mép phải
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDelta; // Dịch sang phải
            }

            // 2. Nếu bấm sang TRÁI (Left Arrow) và chưa chạm mép trái
            if (e.KeyValue == 37 && (xBasket > 0))
            {
                xBasket -= xDelta; // Dịch sang trái
            }

            // 3. Cập nhật vị trí mới
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}