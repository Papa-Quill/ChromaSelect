using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromaSelect.Util
{
    public class NotificationManager
    {
        public static void CreateNotif(Color NotifColor, string NotifText)
        {
            Properties.Settings.Default.NotifColor = NotifColor;
            Properties.Settings.Default.TxtNotif = NotifText;
            Notification notif = new Notification(); notif.Show();
        }
    }
}
