using AutoAccepter.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static AutoAccepter.NotificationsController;

namespace AutoAccepter
{
    public partial class MainForm : Form
    {
        #region Form Magic

        public MainForm()
        {
            InitializeComponent();

            LoadSettings();

            if (!notifycationCheckBox.Checked)
                tokenTextBox.Enabled = false;

            FadeIn();

            stringTimer.Start();
        }

        // Drop shadow
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

        private void LoadSettings()
        {
            if (Settings.Default.token.Length == 0)
                tokenTextBox.Text = "PushBullet Token";
            else
                tokenTextBox.Text = Settings.Default.token;

            notifycationCheckBox.Checked = Settings.Default.notify;
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

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.notify = notifycationCheckBox.Checked;
            Settings.Default.token = tokenTextBox.Text;
            Settings.Default.Save();
        }

        #endregion

        #region Monitoring

        private void startMonitoringButton_Click(object sender, EventArgs e)
        {
            if (notifycationCheckBox.Checked)
            {
                if (tokenTextBox.Text.Length != 34)
                {
                    statusLabel.Text = "Enter your PushBullet Token!";
                    return;
                }
                else if (!CheckToken(tokenTextBox.Text))
                {
                    statusLabel.Text = "PushBullet Token is not correct!";
                    return;
                }
            }

            UpdateControls();

            monitoringWorker.RunWorkerAsync();

            UpdateStatus();
        }

        public void StartMonitoring(BackgroundWorker worker, DoWorkEventArgs e)
        {
            do
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(400);

                if (AudioMeter.CheckForSoundPeak())
                {
                    Thread.Sleep(600);
                    MatchAccepter.Accept();
                    return;
                }
            } while (true);
        }

        private bool flag = false;

        private void monitoringWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
           
            Thread.Sleep(2000); // wait for mute
            StartMonitoring(worker, e);
        }

        private void monitoringWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (notifycationCheckBox.Checked && !flag)
                notificationWorker.RunWorkerAsync();
            flag = false;
            UpdateControls();
            UpdateStatus();          
        }

        private void stopMonitoringButton_Click(object sender, EventArgs e)
        {
            if (monitoringWorker.IsBusy)
            {
                flag = true;
                monitoringWorker.CancelAsync();
            }
        }

        #endregion

        #region Updating Controls

        public void UpdateControls()
        {
            if (!startMonitoringButton.Enabled)
            {
                startMonitoringButton.Textcolor = Color.White;
                startMonitoringButton.Enabled = true;

                sendNotifyLabel.Enabled = true;

                if (notifycationCheckBox.Checked)
                {
                    tokenTextBox.Enabled = true;
                    notifycationCheckBox.BackColor = Color.FromArgb(148, 29, 16);
                }
                else
                {
                    notifycationCheckBox.BackColor = Color.FromArgb(102, 9, 0);
                }
                notifycationCheckBox.Enabled = true;

                stopMonitoringButton.Textcolor = Color.FromArgb(100, 100, 100);
                stopMonitoringButton.Enabled = false;
            }
            else
            {
                startMonitoringButton.Textcolor = Color.FromArgb(100, 100, 100);
                startMonitoringButton.Enabled = false;

                sendNotifyLabel.Enabled = false;
              
                notifycationCheckBox.BackColor = Color.FromArgb(26, 26, 26); 
                notifycationCheckBox.Enabled = false;

                tokenTextBox.Enabled = false;

                stopMonitoringButton.Textcolor = Color.White;
                stopMonitoringButton.Enabled = true;
            }
        }

        private void UpdateStatus()
        {
            if (!monitoringWorker.IsBusy)
            {
                statusLabel.Text = "Click \"AFK\" and go away!";
            }
            else
            {
                statusLabel.Text = "Listening...";
            }
        }

        #endregion

        #region Control Buttons

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Notification

        private void sendNotifyLabel_Click(object sender, EventArgs e)
        {
            notifycationCheckBox.Checked = !notifycationCheckBox.Checked;
            notifycationCheckBox_OnChange(notifycationCheckBox, e);
        }

        private void notificationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Notify(tokenTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notifycationCheckBox_OnChange(object sender, EventArgs e)
        {
            tokenTextBox.Enabled = notifycationCheckBox.Checked;
            tokenTextBox.Focus();
            if (tokenTextBox.Enabled)
            {
                if (Settings.Default.token.Length > 0)
                    tokenTextBox.Text = Settings.Default.token;
                else
                    tokenTextBox.Text = "";
            }
            else
                tokenTextBox.Text = "PushBullet Token";
        }

        #endregion

        #region Misc

        private void stringTimer_Tick(object sender, EventArgs e)
        {
            if (statusLabel.Left > -statusLabel.Width)
            {
                statusLabel.Left -= 2;
            }
            else
            {
                statusLabel.Left = this.Width;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion

        #region Register Link

        private void registerLink_MouseMove(object sender, MouseEventArgs e)
        {
            registerLink.ForeColor = Color.FromArgb(135, 11, 0);
        }

        private void registerLink_MouseLeave(object sender, EventArgs e)
        {
            registerLink.ForeColor = Color.FromArgb(170, 170, 170);
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pushbullet.com/");
        }

        #endregion
    }
}
