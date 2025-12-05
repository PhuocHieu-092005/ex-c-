using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Full_EX
{
    public partial class EX09 : Form
    {
        private const int MAX_HISTORY_LINES = 1000;

        public EX09()
        {
            InitializeComponent();
        }

        private void EX09_Load(object sender, EventArgs e)
        {
          
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void CheckHistoryLimit()
        {
            if (tbKetQua.Lines.Length > MAX_HISTORY_LINES)
            {
              
                List<string> lines = tbKetQua.Lines.ToList();

                
                lines.RemoveAt(0);

               
                tbKetQua.Lines = lines.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(tbSoX.Text, out x) && int.TryParse(tbSoY.Text, out y))
            {
                int kq = x + y;
                string lichSu = x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
                tbKetQua.Text += lichSu;

                CheckHistoryLimit();

                tbSoX.Clear();
                tbSoY.Clear();
                tbSoX.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(tbSoX.Text, out x) && int.TryParse(tbSoY.Text, out y))
            {
                int kq = x * y;

                string lichSu = x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
                tbKetQua.Text += lichSu;

                CheckHistoryLimit();

                tbSoX.Clear();
                tbSoY.Clear();
                tbSoX.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbKetQua.Text))
            {
                MessageBox.Show("Không có lịch sử để lưu.");
                return;
            }

            try
            {
                using (StreamWriter sw = new StreamWriter("Caculator.txt", true))
                {
                    sw.Write(tbKetQua.Text);
                }

                MessageBox.Show("Đã lưu lịch sử tính toán thành công vào tệp Caculator.txt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
            }
        }
    }
}