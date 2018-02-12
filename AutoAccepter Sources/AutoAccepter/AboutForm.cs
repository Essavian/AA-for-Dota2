using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace AutoAccepter
{
    public partial class AboutForm : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public AboutForm()
        {
            InitializeComponent();
            versionLabel.Text += Assembly.GetEntryAssembly().GetName().Version;
            FadeIn();
        }

        private void FadeIn()
        {
            fadeInTimer.Tick += (sender, e) =>
            {
                if ((Opacity = Opacity + 0.1) != 1.0)
                    return;
                fadeInTimer.Stop();
            };
            fadeInTimer.Interval = 30;
            fadeInTimer.Start();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void donateButton_Click(object sender, System.EventArgs e)
        {
            Process.Start("http://www.donationalerts.ru/r/symphony_of_rain");
        }
    }
}
