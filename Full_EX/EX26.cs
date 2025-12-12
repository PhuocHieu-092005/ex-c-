using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO; // Thêm thư viện này để kiểm tra file ảnh có tồn tại không

namespace Full_EX
{
    public partial class EX26 : Form
    {
        // Khai báo đối tượng
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300; 
        int yEgg = 0;   
        int yDelta = 5; 

        public EX26()
        {
            InitializeComponent();
        }

        private void EX26_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình Timer
            tmEgg.Interval = 20;            
            tmEgg.Tick += tmEgg_Tick;       
            tmEgg.Start();                  

            // 2. Cấu hình PictureBox
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage; // Co dãn ảnh cho vừa khung
            pbEgg.Size = new Size(50, 70);
            pbEgg.Location = new Point(xEgg, yEgg);
            
            // [Quan trọng] Đặt nền trong suốt để quả trứng đẹp hơn (không bị viền trắng)
            pbEgg.BackColor = Color.Transparent; 

            // 3. Load ảnh trứng nguyên (Giống Slide 168)
            // Đường dẫn "../../" nghĩa là lùi ra khỏi thư mục bin/Debug để tìm thư mục Images
            string pathEgg = "../../../Images/egg.jpg"; 

            // Kiểm tra xem file có thật sự tồn tại không để tránh lỗi Crash
            if (File.Exists(pathEgg))
            {
                pbEgg.Image = Image.FromFile(pathEgg);
            }
            else
            {
                // Nếu chưa chép ảnh thì dùng màu đỏ tạm
                pbEgg.BackColor = Color.Red; 
            }
            
            this.Controls.Add(pbEgg);       
        }

        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta;

            // Kiểm tra chạm đáy
            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                // [Slide 169] Đổi sang ảnh trứng vỡ
                string pathBroken = "../../../Images/egg_brokne.jpg";
                
                if (File.Exists(pathBroken))
                {
                    pbEgg.Image = Image.FromFile(pathBroken);
                }
                else
                {
                    pbEgg.BackColor = Color.Orange; // Màu cam nếu thiếu ảnh vỡ
                }
                
                tmEgg.Stop(); // Dừng game
                MessageBox.Show("Trứng đã vỡ!", "Game Over");
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}