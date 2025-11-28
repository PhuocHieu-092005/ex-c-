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
    public partial class EX02 : Form
    {
        public EX02()
        {
            InitializeComponent();
        }

        private void EX02_Load(object sender, EventArgs e)
        {

        }

        // [Article 05] 
        private void EX02_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string path = @"E:\C#\buoi1\Key_Logger.txt";
                StreamWriter sw = new StreamWriter(path, true);

                sw.Write(e.KeyCode.ToString() + " ");

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}