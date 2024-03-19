using System;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ChromaSelect
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string fontName = "Azonix";
            if (IsFontInstalled(fontName))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ChromaSelect());
            }
            else
            {
                MessageBox.Show("Please install the Azonix font.\nIn folder with release zip.", "Font Missing!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        static bool IsFontInstalled(string fontName)
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                foreach (FontFamily fontFamily in fontsCollection.Families)
                {
                    if (fontFamily.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
