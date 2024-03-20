using ChromaSelect.Util;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChromaSelect
{
    public partial class ChromaSelect : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams ShadowParams = base.CreateParams;
                    ShadowParams.ExStyle |= 0x02000000;
                    ShadowParams.ClassStyle |= 0x00020000;
                return ShadowParams;
            }
        }

        private void MoveWindow(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { MoveWindowUtil.GrabWindow(this.Handle); }
        }

        private void UpdateTheme()
        {
            if (Properties.Settings.Default.BorderRadius != 0)
            {
                RoundedForms.ApplyRoundedForm(this, Properties.Settings.Default.BorderRadius);
            }
            else
            {
                RoundedForms.ApplyRoundedForm(this, 1);
            }

            // Set focused/hovered border colors
            PanelColorPreview.HoverState.FillColor = SelectedColor;

            var controlsToModify = new Control[] {
                BtnClose, BtnMinimize, BtnColorPicker, BtnHotkeys,
                TxtHexColor, TxtRGBColor, PanelColorPreview };

            foreach (var control in controlsToModify)
            {
                if (control is Guna.UI2.WinForms.Guna2Button button)
                {
                    button.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    button.BorderRadius = Properties.Settings.Default.BorderRadius;
                }
                else if (control is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    textBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                    textBox.BorderRadius = Properties.Settings.Default.BorderRadius;
                }
                else if (control is Guna.UI2.WinForms.Guna2ComboBox comboBox)
                {
                    comboBox.FocusedState.BorderColor = Properties.Settings.Default.DetailActive;
                    comboBox.HoverState.BorderColor = Properties.Settings.Default.DetailActive;
                }
            }
        }

        public ChromaSelect()
        {
            InitializeComponent();
            UpdateTheme();
            PanelColorPreview.MouseClick += PanelColorPreview_MouseClick;
            LabelMadeBy.MouseClick += LabelMadeBy_MouseClick;
            if (Properties.Settings.Default.HotKeyForm) { HotKeys hotKeys = new HotKeys(); hotKeys.Show(); }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                BtnClose.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                BtnClose.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                if (TxtHexColor.Text == "") { NoColorSelected(); return true; }
                Clipboard.SetText(ColorTranslator.ToHtml(SelectedColor));
                NotificationManager.CreateNotif(Color.Lime, "Hex color copied to clipboard!");
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Shift| Keys.C))
            {
                if (TxtHexColor.Text == "") { NoColorSelected(); return true; }
                Clipboard.SetText(TxtRGBColor.Text);
                NotificationManager.CreateNotif(Color.Lime, "RGB color copied to clipboard!");
                return true;
            }
            else if (keyData == (Keys.Control | Keys.K))
            {
                HotKeys hotKeys = new HotKeys(); hotKeys.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        readonly Timer CloseTimer = new Timer();
        private void FadeClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            T1.Tick += new EventHandler(FadeOut);
            T1.Start();

            if (Opacity == 0)
                e.Cancel = false;
        }
        readonly Timer T1 = new Timer();
        private void FadeOut(object sender, EventArgs e)
        {
            CloseTimer.Interval = 50;
            if (Opacity <= 0)
            {
                T1.Stop();
                this.Close();
            }
            else
                Opacity -= 0.3;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseTimer.Tick += new EventHandler(FadeOut);
            CloseTimer.Start();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHotKeys_Click(object sender, EventArgs e)
        {
            HotKeys hotKeys = new HotKeys(); hotKeys.Show();
        }

        public static Color SelectedColor;

        private void Slider_Scroll(object sender, EventArgs e)
        {
            SelectedColor = Color.FromArgb(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            PanelColorPreview.FillColor = SelectedColor;
            TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
            TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
        }

        private void TxtHexColor_Leave(object sender, EventArgs e)
        {
            if (TxtHexColor.Text == "")
            {
                return;
            }
            try
            {
                SelectedColor = ColorTranslator.FromHtml(TxtHexColor.Text);
                TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
                SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
                PanelColorPreview.FillColor = SelectedColor;
            }
            catch (Exception)
            {
                NotificationManager.CreateNotif(Color.Red, "Invalid Hex Color!");
            }
        }

        static bool IsValidRGBColor(string input)
        {
            string pattern = @"^\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*$";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                int r = int.Parse(match.Groups[1].Value);
                int g = int.Parse(match.Groups[2].Value);
                int b = int.Parse(match.Groups[3].Value);

                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    return true;
                }
            }

            return false;
        }

        static Color ConvertToColor(string input)
        {
            string pattern = @"^\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*$";
            var match = System.Text.RegularExpressions.Regex.Match(input, pattern);

            if (match.Success)
            {
                int r = int.Parse(match.Groups[1].Value);
                int g = int.Parse(match.Groups[2].Value);
                int b = int.Parse(match.Groups[3].Value);

                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    return Color.FromArgb(r, g, b);
                }
            }
            NotificationManager.CreateNotif(Color.Red, "Invalid RGB Color!");
            return Color.Black;
        }

        private void TxtRGBColor_Leave(object sender, EventArgs e)
        {
            if (TxtRGBColor.Text == "")
            {
                return;
            }
            if (IsValidRGBColor(TxtRGBColor.Text))
            {
                SelectedColor = ConvertToColor(TxtRGBColor.Text);
                TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
                SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
                PanelColorPreview.FillColor = SelectedColor;
            }
            else
            {
                NotificationManager.CreateNotif(Color.Red, "Invalid RGB Color!");
            }
        }

        private void BtnColorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            BtnColorPicker.MouseMove += BtnColorPicker_MouseMove;
            Cursor = Cursors.Cross;
        }

        private void BtnColorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            BtnColorPicker.MouseMove -= BtnColorPicker_MouseMove;
            Cursor = Cursors.Default;
        }

        private void BtnColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = GetColorAtCursor();
            SelectedColor = color;
            PanelColorPreview.FillColor = SelectedColor;
            TxtHexColor.Text = ColorTranslator.ToHtml(SelectedColor);
            TxtRGBColor.Text = SelectedColor.R.ToString() + ", " + SelectedColor.G.ToString() + ", " + SelectedColor.B.ToString();
            SliderRed.Value = SelectedColor.R; SliderGreen.Value = SelectedColor.G; SliderBlue.Value = SelectedColor.B;
        }

        private Color GetColorAtCursor()
        {
            Point cursorPos = Cursor.Position;
            Bitmap screenPixel = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(screenPixel))
            {
                g.CopyFromScreen(cursorPos, Point.Empty, new Size(1, 1));
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void ChromaSelect_Enter(object sender, EventArgs e) { UpdateTheme(); }

        private void NoColorSelected() { NotificationManager.CreateNotif(Color.Red, "No color selected!"); }

        private void PanelColorPreview_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtHexColor.Text == "") { NoColorSelected(); return; }
            if (Control.ModifierKeys == Keys.Control)
            {
                Clipboard.SetText($"RGB: {TxtRGBColor.Text}\nHex: {TxtHexColor.Text}");
                NotificationManager.CreateNotif(Color.Lime, "Full color copied to clipboard!");
            }
            else if (e.Button == MouseButtons.Left)
            {
                Clipboard.SetText(ColorTranslator.ToHtml(SelectedColor));
                NotificationManager.CreateNotif(Color.Lime, "Hex color copied to clipboard!");
            }
            else if (e.Button == MouseButtons.Right)
            {
                Clipboard.SetText(TxtRGBColor.Text);
                NotificationManager.CreateNotif(Color.Lime, "RGB color copied to clipboard!");
            }
        }

        private void LabelMadeBy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Process.Start("https://github.com/Papa-Quill/");
            }
            else
            {
                Process.Start("https://github.com/Papa-Quill/");
            }
        }
    }
}
