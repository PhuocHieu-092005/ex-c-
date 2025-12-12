using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX14 : Form
    {
        public EX14()
        {
            InitializeComponent();
        }

        // [Slide 106] Xử lý khi tick vào ô "Giảm giá"
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true;  // Nếu tick thì cho nhập số %
                tbDiscount.Focus();         // Đưa con trỏ chuột vào ô nhập luôn cho tiện
            }
            else
            {
                tbDiscount.Enabled = false; // Bỏ tick thì khóa ô nhập lại
                tbDiscount.Clear();         // Xóa số cũ đi
            }
        }

        // [Slide 106] Xử lý nút "Tính tiền"
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // 1. Kiểm tra giới tính
            if (rbMale.Checked == true)
                msg += "Ông ";             //

            if (rbFemale.Checked == true)
                msg += "Bà ";              //

            // 2. Kiểm tra giảm giá
            if (ckDiscount.Checked == true)
            {
                // Lấy giá trị từ ô nhập liệu (Slide code cứng là 5, nhưng mình lấy từ ô nhập cho đúng thực tế)
                if (int.TryParse(tbDiscount.Text, out int value))
                {
                    disc = value;
                }
                else
                {
                    disc = 0; // Nhập sai thì tính là 0
                }
            }

            // 3. Hiển thị kết quả ra màn hình
            // - Dòng code ghép chuỗi kết quả
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Xử lý nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}