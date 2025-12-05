using System;
using System.Windows.Forms;

namespace Full_EX
{
    public partial class EX10 : Form
    {
        // [Slide 78] Khai báo biến toàn cục
        decimal workingMemory = 0;
        string opr = "";

        public EX10()
        {
            InitializeComponent();
        }

        // --- CODE XỬ LÝ SỐ (0, 1, 2, 3) ---
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1"; //
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2"; //
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // --- CODE XỬ LÝ PHÉP TÍNH (+, *) ---
        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = "+";
            if (decimal.TryParse(tbDisplay.Text, out decimal val))
            {
                workingMemory = val; //
            }
            tbDisplay.Clear(); //
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = "*";
            if (decimal.TryParse(tbDisplay.Text, out decimal val))
            {
                workingMemory = val;
            }
            tbDisplay.Clear();
        }

        // --- CODE XỬ LÝ DẤU BẰNG (=) ---
        private void btEquals_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbDisplay.Text, out decimal secondValue)) //
            {
                if (opr == "+")
                {
                    tbDisplay.Text = (workingMemory + secondValue).ToString(); //
                }
                if (opr == "*")
                {
                    tbDisplay.Text = (workingMemory * secondValue).ToString(); //
                }
            }
        }
    }
}