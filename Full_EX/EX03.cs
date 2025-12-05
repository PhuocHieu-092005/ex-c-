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
    public partial class EX03 : Form
    {
        public EX03()
        {
            InitializeComponent();
        }

        private void EX03_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string so = numericUpDown1.Value.ToString();
            string ngay = dateTimePicker1.Value.ToShortDateString();

            string trangThai = "";
            if (checkBox1.Checked) trangThai += "Đã tick CheckBox. ";
            if (radioButton1.Checked) trangThai += "Đã chọn RadioButton.";


            string mucChon = "";
            if (listBox1.SelectedItem != null)
            {
                mucChon = listBox1.SelectedItem.ToString();
            }


            string thongBao = "Tên: " + ten + "\n"
                            + "Số lượng: " + so + "\n"
                            + "Ngày: " + ngay + "\n"
                            + "Trạng thái: " + trangThai + "\n"
                            + "Mục đã chọn: " + mucChon;


            MessageBox.Show(thongBao, "Kết quả");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EX03_Load_1(object sender, EventArgs e)
        {

        }
    }
}
