using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX15 : Form
    {
        public EX15()
        {
            InitializeComponent();
        }

        // [Slide 110] Sự kiện khi bấm nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy ngày đã chọn, chuyển thành chuỗi DÀI (LongDateString)
            // Ví dụ: "Thứ Sáu, ngày 12 tháng 12 năm 2025"
            this.Text = dtpDate.Value.ToLongDateString(); //
        }

        // [Slide 110] Sự kiện khi thay đổi ngày trên lịch
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày đã chọn, chuyển thành chuỗi NGẮN (ShortDateString)
            // Ví dụ: "12/12/2025"
            this.Text = dtpDate.Value.ToShortDateString(); //
        }
    }
}