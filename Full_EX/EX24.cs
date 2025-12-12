using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX24 : Form
    {
        // Biến đếm số giây
        int second = 0; //

        public EX24()
        {
            InitializeComponent();
        }

        // [Slide 159] Nút Start -> Cài đặt thời gian và Chạy
        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000; // 1000ms = 1 giây
            tmStopwatch.Start();         // Bắt đầu đếm
        }

        // [Slide 159] Nút Stop -> Dừng đếm
        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop(); //
        }

        // [Slide 159] Sự kiện Tick -> Chạy mỗi giây 1 lần
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++; // Tăng biến giây lên 1
            lblDisplay.Text = second.ToString(); // Hiển thị ra màn hình
        }
    }
}