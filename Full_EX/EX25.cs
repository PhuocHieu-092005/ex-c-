using System;
using System.Drawing; // Cần thư viện này để dùng Color, Size, Point
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX25 : Form
    {
        // [Slide 162] Khai báo các đối tượng và biến toàn cục
        PictureBox pb = new PictureBox(); // Tạo quả bóng
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();
        // Tọa độ ban đầu của bóng
        int xBall = 0;
        int yBall = 0;

        // Tốc độ di chuyển (Mỗi lần nhích 5 pixel)
        int xDelta = 5;
        int yDelta = 5;

        public EX25()
        {
            InitializeComponent();
        }

        // [Slide 163] Sự kiện Form Load: Thiết lập game
        private void EX25_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình Timer
            tmGame.Interval = 10;             // Tốc độ game (số càng nhỏ bóng chạy càng nhanh)
            tmGame.Tick += tmGame_Tick;       // Gán sự kiện chạy cho Timer
            tmGame.Start();                   // Bắt đầu chạy

            // 2. Cấu hình Quả bóng (PictureBox)
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(50, 50);       // Kích thước bóng (nhỏ lại chút cho đẹp)
            pb.Location = new Point(xBall, yBall);

            // Mẹo: Đặt màu nền để nếu không có ảnh vẫn nhìn thấy bóng
            pb.BackColor = Color.Red;

            // Nếu bạn có ảnh bóng, hãy bỏ comment dòng dưới và sửa đường dẫn
            // pb.ImageLocation = @"D:\ball.png"; //

            // QUAN TRỌNG: Thêm bóng vào Form
            this.Controls.Add(pb);            //
        }

        // [Slide 163] Sự kiện Tick: Được gọi liên tục mỗi 10ms
        void tmGame_Tick(object sender, EventArgs e)
        {
            // 1. Cập nhật tọa độ mới
            xBall += xDelta; //
            yBall += yDelta; //

            // 2. Xử lý va chạm TRÁI - PHẢI
            // Nếu bóng chạm mép phải HOẶC mép trái -> Đảo chiều ngang
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0) //
            {
                xDelta = -xDelta;
            }

            // 3. Xử lý va chạm TRÊN - DƯỚI
            // Nếu bóng chạm mép dưới HOẶC mép trên -> Đảo chiều dọc
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0) //
            {
                yDelta = -yDelta;
            }

            // 4. Cập nhật vị trí bóng lên màn hình
            pb.Location = new Point(xBall, yBall); //
        }
    }
}