using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    abstract class Hareket
    {
        public Boolean hareketHesapla(PictureBox seciliOlan, PictureBox eskiPb)
        {
            
            if (eskiPb == seciliOlan)
            {
                return false;
            }
            else if (eskiPb == null)
            {
                return true;
            }
            else if((seciliOlan.BackColor==Color.Brown))
            {
                return false;
            }
            
            else if (seciliOlan.Image != null && eskiPb.Image != seciliOlan.Image)
            {
                return true;
            }
            else if ((-47 <= seciliOlan.Location.X - eskiPb.Location.X && seciliOlan.Location.X - eskiPb.Location.X <= 47) 
                && (-47 <= seciliOlan.Location.Y - eskiPb.Location.Y && seciliOlan.Location.Y - eskiPb.Location.Y <= 47))
            {
                    return true;
            }
            else
                return false;

        }
    }
}
