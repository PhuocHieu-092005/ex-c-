using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX12 : Form
    {
        public EX12()
        {
            InitializeComponent();
        }

        // [Slide 96] Sự kiện Load: Mặc định chọn dòng thứ 3 (Index = 2)
        private void EX12_Load(object sender, EventArgs e)
        {
            // Index bắt đầu từ 0. Index = 2 tức là "Quản trị kinh doanh"
            cb_Faculty.SelectedIndex = 2; //
        }

        // [Slide 96] Sự kiện ComboBox: Khi người dùng chọn khoa khác
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            // Hiển thị số thứ tự của khoa vừa chọn
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString(); //
        }

        // [Slide 96] Sự kiện Nút bấm OK: Hiển thị tên khoa
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy dòng hiện tại (SelectedItem)
            var item = cb_Faculty.SelectedItem;

            if (item != null)
            {
                // Hiển thị tên khoa ra màn hình
                tbDisplay.Text = "Bạn là sinh viên khoa : " + item.ToString(); //
            }
        }
    }
}