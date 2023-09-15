using System;
using System.Drawing;
using System.Windows.Forms;

namespace Toaster
{
    public partial class ConfigForm : Form
    {
        public delegate void SaveCallback(Config config);
        public delegate void StopCallback();

        private readonly Config config;
        private readonly SaveCallback onSave;
        private readonly StopCallback onStop;

        public ConfigForm(Config config, SaveCallback onSave, StopCallback onStop)
        {
            InitializeComponent();

            this.onSave = onSave;
            this.onStop = onStop;

            this.config = config;
            inputTitle.Text = config.ToastTitle;
            inputTimeout.Value = config.Timeout;
            inputCorner.Text = config.Corner;
            inputOffsetX.Value = config.OffsetX;
            inputOffsetY.Value = config.OffsetY;

            // Originally I would exit the app if the user closed the form this
            // way but that might seem unintuitive for an app running in the
            // background most of the time.
            FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    hideInTray();
                }
            };
            Resize += OnMinimize;

            // Hide initially
            hideInTray();
        }

        private void OnMinimize(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                hideInTray();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            config.ToastTitle = inputTitle.Text;
            config.Timeout = (int)inputTimeout.Value;
            config.Corner = inputCorner.Text;
            config.OffsetX = (int)inputOffsetX.Value;
            config.OffsetY = (int)inputOffsetY.Value;
            onSave(config);
            hideInTray();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            onStop();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openForm();
        }

        private void openFormMenuItem_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            onStop();
        }

        private void openForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void hideInTray()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

    }
}
