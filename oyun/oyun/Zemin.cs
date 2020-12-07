using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    class Zemin
    {
        public List<PictureBox> zemin = new List<PictureBox>();


        public void zeminListele( PictureBox nesne)
        {
            //nesneleri listelere ekliyoruz.
            zemin.Add(nesne);
        }

       
    }
}
