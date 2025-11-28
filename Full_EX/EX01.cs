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
        string path = @"E:\C#\buoi1\form.xml";

        public EX01()
        {
            InitializeComponent();
        }
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

        public InfoWindows Read()
        {
            if (!File.Exists(path)) return null;

            XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
            StreamReader file = new StreamReader(path);

            InfoWindows iw = (InfoWindows)reader.Deserialize(file);

            file.Close();
            return iw;
        }
        private void EX01_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();

            iw = Read();

            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
            }

            this.Text = this.Width + " - " + this.Height;
        }

        private void EX01_ResizeEnd(object sender, EventArgs e)
        {
            this.Text = this.Width + " - " + this.Height;

            InfoWindows iw = new InfoWindows();
            iw.Width = this.Width;
            iw.Height = this.Height;
            Write(iw);
        }
    }

    public class InfoWindows
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}