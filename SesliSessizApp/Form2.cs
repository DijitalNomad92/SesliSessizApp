using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form2 : Form
    {
        StringIslemleriService _servis = new StringIslemleriService();
        public Form2()
        {
            InitializeComponent();
        }

        private void btBul_Click(object sender, EventArgs e)
        {
            rtbCumle.Text = _servis.İlkHarfleriBuyult(tbCumle.Text);
        }
    }
}
