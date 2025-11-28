using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX08 : Form
    {
        public EX08()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EX08_Load(object sender, EventArgs e)
        {

        }

        private void tbSoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(tbSoX.Text, out x) && int.TryParse(tbSoY.Text, out y))
            {
                int kq = x * y;
                tbKetQua.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(tbSoX.Text, out x) && int.TryParse(tbSoY.Text, out y))
            {
                int kq = x + y;
                tbKetQua.Text = kq.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void tbSoX_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbSoY_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}