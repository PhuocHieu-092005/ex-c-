using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Full_EX
{
    public partial class EX04 : Form
    {
        public EX04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Article for Button";
            this.Size = new Size(500, 500);
        }

        private void EX04_Load(object sender, EventArgs e)
        {

        }
    }
}
