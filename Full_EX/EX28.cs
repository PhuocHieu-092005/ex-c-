using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Full_EX
{
    public partial class EX28 : Form
    {
        // 1. Khai báo các đối tượng: Giỏ, Trứng, Gà [Slide 178]
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();

        // 2. Khai báo Timer
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();

        // 3. Tọa độ và tốc độ
        // GIỎ
        int xBasket = 300;
        int yBasket = 380;
        int xDeltaBasket = 30;

        // GÀ
        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5;

        // TRỨNG
        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 5;

        public EX28()
        {
            InitializeComponent();
        }

        private void EX28_Load(object sender, EventArgs e)
        {
            // --- CẤU HÌNH TIMER ---
            tmEgg.Interval = 20;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 20; // [Slide 179]
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            // --- CẤU HÌNH CON GÀ ---
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            // Load ảnh gà (có màu hồng dự phòng)
            string pathChicken = "../../../Images/chicken.png";
            if (File.Exists(pathChicken)) pbChicken.Image = Image.FromFile(pathChicken);
            else pbChicken.BackColor = Color.Pink;
            this.Controls.Add(pbChicken);

            // --- CẤU HÌNH CÁI GIỎ ---
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            // Load ảnh giỏ (có màu xanh dự phòng)
            string pathBasket = "../../../Images/basket.png";
            if (File.Exists(pathBasket)) pbBasket.Image = Image.FromFile(pathBasket);
            else pbBasket.BackColor = Color.Blue;
            this.Controls.Add(pbBasket);

            // --- CẤU HÌNH QUẢ TRỨNG ---
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(30, 40);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            // Load ảnh trứng (có màu vàng dự phòng)
            string pathEgg = "../../../Images/egg.jpg";
            if (File.Exists(pathEgg)) pbEgg.Image = Image.FromFile(pathEgg);
            else pbEgg.BackColor = Color.Gold;
            this.Controls.Add(pbEgg);
            // Đưa trứng lên trên cùng để không bị giỏ che khuất
            pbEgg.BringToFront();
        }

        // [Slide 181] LOGIC CON GÀ DI CHUYỂN
        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            // Nếu chạm mép phải hoặc trái thì đảo chiều
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken;
            }
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        // [Slide 184] LOGIC TRỨNG RƠI & VA CHẠM
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            // 1. Kiểm tra va chạm với GIỎ (Hứng được trứng)
            // Lệnh Intersect dùng để xem 2 hình chữ nhật có đè lên nhau không [Slide 184]
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);

            if (unionRect.IsEmpty == false) // Nếu KHÔNG rỗng => Có va chạm => Hứng trúng!
            {
                // Reset trứng về vị trí con gà hiện tại [Slide 184]
                yEgg = yChicken + 50;
                xEgg = pbChicken.Location.X + 20; // Lấy tọa độ X của gà
            }

            // 2. Kiểm tra va chạm với SÀN (Trượt tay)
            else if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                // Đổi ảnh vỡ
                string pathBroken = "../../../Images/egg_brokne.jpg";
                if (File.Exists(pathBroken)) pbEgg.Image = Image.FromFile(pathBroken);
                else pbEgg.BackColor = Color.OrangeRed;

                tmEgg.Stop();
                tmChicken.Stop(); // Dừng cả gà
                MessageBox.Show("Game Over! Bạn đã làm vỡ trứng.", "Thua cuộc");
                return; // Thoát hàm
            }

            // Cập nhật vị trí trứng
            pbEgg.Location = new Point(xEgg, yEgg);
        }

        // [Slide 182] LOGIC ĐIỀU KHIỂN GIỎ (Bàn phím)
        private void EX28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width)) // Phải
                xBasket += xDeltaBasket;

            if (e.KeyValue == 37 && (xBasket > 0)) // Trái
                xBasket -= xDeltaBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}