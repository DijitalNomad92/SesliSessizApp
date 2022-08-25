using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form1 : Form
    {
        StringIslemleriService _service = new StringIslemleriService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btBul_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = _service.SesliSessizHarfBul(tbKelime.Text.Trim(), rbSesli.Checked);
        }

        private void btTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Text = "";
            rbSesli.Checked = true;
            rtbSonuc.Text = "";

        }
    }
}