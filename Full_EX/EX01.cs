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
        // [EX01]
        string path = @"E:\C#\buoi1\form.xml";

        public EX01()
        {
            InitializeComponent();
        }

        // [EX01] Hàm GHI dữ liệu (Write)
        public void Write(InfoWindows iw)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        // [EX02] Hàm ĐỌC dữ liệu (Read) 
        public InfoWindows Read()
        {
            if (!File.Exists(path)) return null;

            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);

            InfoWindows iw = (InfoWindows)reader.Deserialize(file);

            file.Close();
            return iw;
        }

        // [EX00] Sự kiện Load: Chạy khi Form bắt đầu hiện lên
        private void EX01_Load(object sender, EventArgs e)
        {
            // [EX02]
            InfoWindows iw = Read();

            if (iw != null)
            {
                // [EX02]
                this.Width = iw.Width;
                this.Height = iw.Height;

                // [EX03]
                this.Location = iw.Location;
            }

            // [EX00]
            this.Text = this.Width + " - " + this.Height;
        }

        // [EX00] Sự kiện ResizeEnd
        private void EX01_ResizeEnd(object sender, EventArgs e)
        {
            // [EX00] Chỉ cập nhật lại tiêu đề cho đúng số đo mới
            this.Text = this.Width + " - " + this.Height;
        }

        // [EX03] Sự kiện FormClosing
        private void EX01_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();

            iw.Width = this.Width;
            iw.Height = this.Height;

            iw.Location = this.Location;

            Write(iw);
        }
    }
    // Class chung dùng cho 3 bài EX
    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // [EX03] 
        public Point Location { get; set; }
    }
}