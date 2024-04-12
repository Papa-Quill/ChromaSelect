using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChromaSelect.Util
{
    public partial class Notification : Form
    {
        static int GetTextWidth(string text)
        {
            using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                using (Font font = new Font("Segoe UI", 12))
                {
                    SizeF size = graphics.MeasureString(text, font);
                    return (int)size.Width;
                }
            }
        }
        readonly Timer CloseTimer = new Timer();
        private static readonly List<Notification> activeNotifications = new List<Notification>();

        public Notification()
        {
            InitializeComponent();
            Width = GetTextWidth(Properties.Settings.Default.TxtNotif) + 105;
            NotifBox.Width = GetTextWidth(Properties.Settings.Default.TxtNotif) + 80;

            CloseTimer.Interval = 3000; // 3 secs
            CloseTimer.Tick += new EventHandler(FadeOut);
            CloseTimer.Start();

            if (activeNotifications.Any())
            {
                Notification lastNotification = activeNotifications.Last();
                Location = new Point(0, lastNotification.Bottom);
            }
            else
            {
                Location = new Point(0, 0);
            }

            activeNotifications.Add(this);
            this.FormClosed += Notification_FormClosed;
            TxtNotif.Text = Properties.Settings.Default.TxtNotif;
            PanelNotifColor.FillColor = Properties.Settings.Default.NotifColor;
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            activeNotifications.Remove(this);
            foreach (var notification in activeNotifications)
            {
                notification.Top -= Height;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void NotifBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotifClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            T1.Tick += new EventHandler(FadeOut);
            T1.Start();


            if (Opacity == 0)
                e.Cancel = false;

        }

        readonly Timer T1 = new Timer();
        void FadeOut(object sender, EventArgs e)
        {
            CloseTimer.Interval = 50;
            if (Opacity <= 0)
            {
                T1.Stop();
                Close();
            }
            else
                Opacity -= 0.3;
        }

        private void NotifBox_MouseHover(object sender, EventArgs e)
        {
            CloseTimer.Enabled = false;
            Opacity = 1;
        }

        private void NotifBox_MouseLeave(object sender, EventArgs e)
        {
            CloseTimer.Enabled = true;
        }
    }
}
