namespace Full_EX
{
    public partial class Full_EX : Form
    {
        public Full_EX()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EX01 frm = new EX01();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EX02 frm = new EX02();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EX03 frm = new EX03();
            frm.Show();
        }
    }
}