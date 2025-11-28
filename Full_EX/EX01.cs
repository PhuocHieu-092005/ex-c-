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
using System.Xml.Serialization;  

namespace Full_EX
{
    public partial class EX01 : Form
    {
        // 1. Khai báo đường dẫn lưu file
        string path = @"E:\C#\buoi1\form.xml";

        public EX01()
        {
            InitializeComponent();
        }

        // 2. Hàm thực hiện việc ghi dữ liệu ra file XML
        public void Write(InfoWindows iw)
        {
        
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));

           
            StreamWriter file = new StreamWriter(path);

            writer.Serialize(file, iw);

            file.Close();
        }

        private void EX01_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            this.Text = width.ToString() + " - " + height.ToString();

            InfoWindows iw = new InfoWindows();
            iw.Width = width;
            iw.Height = height;
            Write(iw); 
        }

        private void EX01_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

   
            this.Text = width.ToString() + " - " + height.ToString();

            InfoWindows iw = new InfoWindows();
            iw.Width = width;
            iw.Height = height;
            Write(iw); 
        }
    }

    // 3.Class chứa thông tin chiều rộng, chiều cao 
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}