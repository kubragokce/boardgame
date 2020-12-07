using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    class Taslar:Hareket
    {
        Zemin zmn = new Zemin();
        public List<PictureBox> sarilar = new List<PictureBox>();
        public List<PictureBox> sarilar2 = new List<PictureBox>();
        public PictureBox secilen = null;
        public Color eski;

        public void taslariListele(PictureBox nesne)
        {
            //nesneleri listelere ekliyoruz.
            sarilar.Add(nesne);

        }
        public void taslariListele2(PictureBox nesne)
        {
            //nesneleri listelere ekliyoruz.
            sarilar.Add(nesne);

        }

        
        public void secim(object nesne)
        {
            PictureBox dosya = (PictureBox)nesne;
            if (dosya.Image != null)
            {
                try { secilen.BackColor = eski; }
                catch { }
                secilen = dosya;
                 eski = secilen.BackColor;
                secilen.BackColor = Color.Lime;
            }
            
        }

        public void taslariYerlestir(List<PictureBox> zemin)
        {
            foreach (PictureBox tas in sarilar)
            {
                if (tas.Image != null)
                {

                    do
                    {
                        tasYerlestir(zemin, tas);
                    }
                    while (tasYerlestir(zemin, tas) == false);
                }
            }
        }
        public Boolean tasYerlestir(List<PictureBox> zemin,PictureBox tas)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, zemin.Count);

            if (zemin[sayi].Image == null && zemin[sayi].BackColor != Color.Brown)
            {
                zemin[sayi].Image = tas.Image;
                tas.Image = null;
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
