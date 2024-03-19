using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChromaSelect.Util
{
    public partial class HotKeys : Form
    {
        public HotKeys()
        {
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);
            InitializeComponent();
        }

        private void HotKeys_Click(object sender, EventArgs e)
        {
            Close();
            Properties.Settings.Default.HotKeyForm = false;
            Properties.Settings.Default.Save();
        }
    }
}
