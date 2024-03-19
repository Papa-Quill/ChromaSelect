using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChromaSelect.Util
{
    internal static class RoundedForms
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public static void ApplyRoundedForm(Form form, int radius)
        {
            radius *= 3;
            form.FormBorderStyle = FormBorderStyle.None;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(form.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, form.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                form.Region = new Region(path);
            }
        }
    }
}
