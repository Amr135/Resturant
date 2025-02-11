using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    internal static class Utility
    {
 
        public static void BlurBackGround(Form Frm)
        {
            Form BackGround=new Form();
            using (Frm)
            {
                BackGround.StartPosition = FormStartPosition.Manual;
                BackGround.FormBorderStyle=FormBorderStyle.None;
                BackGround.Opacity = 0.5d;
                BackGround.Size =FrmMain.Instance.Size;
                BackGround.Location = FrmMain.Instance.Location;
                BackGround.BackColor=Color.Black;
                BackGround.ShowInTaskbar =false;//prevent show when put mouse on the icon of app
                BackGround.Show();
               Frm.Owner=BackGround;
                Frm.ShowDialog(BackGround);
                BackGround.Dispose();
            }

        }
    }
}
