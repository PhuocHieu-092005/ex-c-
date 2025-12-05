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
    public partial class EX11 : Form
    {
        // 1. Khai báo các biến toàn cục để tính toán
        decimal memory = 0;          
        decimal workingMemory = 0;   
        string opr = "";             

        public EX11()
        {
            InitializeComponent();

            // 2. KỸ THUẬT TỰ ĐỘNG KẾT NỐI SỰ KIỆN (AUTO WIRING)
          
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Click += new EventHandler(Button_Click);
                }
            }
        }

        private void EX11_Load(object sender, EventArgs e)
        {
          
        }

        // 3. Hàm xử lý logic trung tâm (Logic giống hệt bài EX10 nhưng khớp với tên nút của bạn)
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string txt = bt.Text;

            // --- NHÓM 1: NHẬP SỐ VÀ DẤU CHẤM ---
            if ((char.IsDigit(txt, 0) && txt.Length == 1) || txt == ".")
            {
                if (textBox1.Text == "0" && txt != ".") textBox1.Clear();
                if (txt == "." && textBox1.Text.Contains(".")) return;

                textBox1.Text += txt;
            }

            // --- NHÓM 2: CÁC PHÉP TOÁN CƠ BẢN ---
            else if (txt == "+" || txt == "-" || txt == "*" || txt == "/")
            {
                opr = txt;
                decimal.TryParse(textBox1.Text, out workingMemory);
                textBox1.Clear();
            }

            // --- NHÓM 3: DẤU BẰNG (=) ---
            else if (txt == "=")
            {
                decimal secondValue = 0;
                decimal.TryParse(textBox1.Text, out secondValue);

                switch (opr)
                {
                    case "+": textBox1.Text = (workingMemory + secondValue).ToString(); break;
                    case "-": textBox1.Text = (workingMemory - secondValue).ToString(); break;
                    case "*": textBox1.Text = (workingMemory * secondValue).ToString(); break;
                    case "/":
                        if (secondValue != 0) textBox1.Text = (workingMemory / secondValue).ToString();
                        else textBox1.Text = "Error";
                        break;
                }
            }

            // --- NHÓM 4: CÁC CHỨC NĂNG ĐẶC BIỆT ---

            // Dấu âm dương (±)
            else if (txt == "±")
            {
                if (decimal.TryParse(textBox1.Text, out decimal val))
                    textBox1.Text = (-val).ToString();
            }
            // Căn bậc 2 
            else if (txt == "✓")
            {
                if (double.TryParse(textBox1.Text, out double val) && val >= 0)
                    textBox1.Text = Math.Sqrt(val).ToString();
            }
            // Phần trăm (%)
            else if (txt == "%")
            {
                if (decimal.TryParse(textBox1.Text, out decimal val))
                    textBox1.Text = (val / 100).ToString();
            }
            // Nghịch đảo (1/x)
            else if (txt == "1/x")
            {
                if (decimal.TryParse(textBox1.Text, out decimal val) && val != 0)
                    textBox1.Text = (1 / val).ToString();
            }
            // Xóa ký tự 
            else if (txt == "⬅")
            {
                if (textBox1.TextLength > 0)
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            }
            // Xóa sạch (C)
            else if (txt == "C")
            {
                workingMemory = 0;
                opr = "";
                textBox1.Clear();
            }
            // Xóa dòng nhập (CE)
            else if (txt == "CE")
            {
                textBox1.Clear();
            }

            // --- NHÓM 5: BỘ NHỚ (MEMORY) ---
            else if (txt == "MC") memory = 0;
            else if (txt == "MR") textBox1.Text = memory.ToString();
            else if (txt == "MS") decimal.TryParse(textBox1.Text, out memory);
            else if (txt == "M+")
            {
                if (decimal.TryParse(textBox1.Text, out decimal val)) memory += val;
            }
            else if (txt == "M-")
            {
                if (decimal.TryParse(textBox1.Text, out decimal val)) memory -= val;
            }
        }
    }
}