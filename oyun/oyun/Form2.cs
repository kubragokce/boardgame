using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form2 : Form
    {
        Taslar taslar = new Taslar();//Taslar sinifinin nesnesini olusturduk
        Zemin zmn = new Zemin();//Zemin sinifinin nesnesini olusturduk
        public static PictureBox eskiPb;
        public static PictureBox seciliOlan = null;
        public static PictureBox sender { get; set; }
        int sayac = 0;
        public Form2()
        {
            InitializeComponent();
            taslariListele2();
            zeminListele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void baslat_bttn_Click_1(object sender, EventArgs e)
        {
            taslar.taslariYerlestir(zmn.zemin);
        }

        public void sari_tas(object sender, MouseEventArgs e)
        {
            taslar.secim(sender);
        }

        private void engelKoy(object sender, EventArgs e)
        {
            PictureBox dosya = (PictureBox)sender;
            if (dosya.Image == null)
            {
                dosya.BackColor = Color.Brown;
            }

        }


        public void taslariListele2()
        {
            taslar.taslariListele(sari1);
            taslar.taslariListele(sari2);
            taslar.taslariListele(sari3);
            taslar.taslariListele(sari4);
            taslar.taslariListele(sari5);
            taslar.taslariListele(sari6);
            taslar.taslariListele(sari7);
            taslar.taslariListele(sari8);
        }
        public void zeminListele()
        {
            zmn.zeminListele(A1);
            zmn.zeminListele(B1);
            zmn.zeminListele(C1);
            zmn.zeminListele(D1);
            zmn.zeminListele(E1);
            zmn.zeminListele(F1);
            zmn.zeminListele(G1);
            zmn.zeminListele(H1);
            zmn.zeminListele(I1);
            zmn.zeminListele(J1);

            zmn.zeminListele(A2);
            zmn.zeminListele(B2);
            zmn.zeminListele(C2);
            zmn.zeminListele(D2);
            zmn.zeminListele(E2);
            zmn.zeminListele(F2);
            zmn.zeminListele(G2);
            zmn.zeminListele(H2);
            zmn.zeminListele(I2);
            zmn.zeminListele(J2);

            zmn.zeminListele(A3);
            zmn.zeminListele(B3);
            zmn.zeminListele(C3);
            zmn.zeminListele(D3);
            zmn.zeminListele(E3);
            zmn.zeminListele(F3);
            zmn.zeminListele(G3);
            zmn.zeminListele(H3);
            zmn.zeminListele(I3);
            zmn.zeminListele(J3);

            zmn.zeminListele(A4);
            zmn.zeminListele(B4);
            zmn.zeminListele(C4);
            zmn.zeminListele(D4);
            zmn.zeminListele(E4);
            zmn.zeminListele(F4);
            zmn.zeminListele(G4);
            zmn.zeminListele(H4);
            zmn.zeminListele(I4);
            zmn.zeminListele(J4);

            zmn.zeminListele(A5);
            zmn.zeminListele(B5);
            zmn.zeminListele(C5);
            zmn.zeminListele(D5);
            zmn.zeminListele(E5);
            zmn.zeminListele(F5);
            zmn.zeminListele(G5);
            zmn.zeminListele(H5);
            zmn.zeminListele(I5);
            zmn.zeminListele(J5);

            zmn.zeminListele(A6);
            zmn.zeminListele(B6);
            zmn.zeminListele(C6);
            zmn.zeminListele(D6);
            zmn.zeminListele(E6);
            zmn.zeminListele(F6);
            zmn.zeminListele(G6);
            zmn.zeminListele(H6);
            zmn.zeminListele(I6);
            zmn.zeminListele(J6);

            zmn.zeminListele(A7);
            zmn.zeminListele(B7);
            zmn.zeminListele(C7);
            zmn.zeminListele(D7);
            zmn.zeminListele(E7);
            zmn.zeminListele(F7);
            zmn.zeminListele(G7);
            zmn.zeminListele(H7);
            zmn.zeminListele(I7);
            zmn.zeminListele(J7);

            zmn.zeminListele(A8);
            zmn.zeminListele(B8);
            zmn.zeminListele(C8);
            zmn.zeminListele(D8);
            zmn.zeminListele(E8);
            zmn.zeminListele(F8);
            zmn.zeminListele(G8);
            zmn.zeminListele(H8);
            zmn.zeminListele(I8);
            zmn.zeminListele(J8);

            zmn.zeminListele(A9);
            zmn.zeminListele(B9);
            zmn.zeminListele(C9);
            zmn.zeminListele(D9);
            zmn.zeminListele(E9);
            zmn.zeminListele(F9);
            zmn.zeminListele(G9);
            zmn.zeminListele(H9);
            zmn.zeminListele(I9);
            zmn.zeminListele(J9);

            zmn.zeminListele(A10);
            zmn.zeminListele(B10);
            zmn.zeminListele(C10);
            zmn.zeminListele(D10);
            zmn.zeminListele(E10);
            zmn.zeminListele(F10);
            zmn.zeminListele(G10);
            zmn.zeminListele(H10);
            zmn.zeminListele(I10);
            zmn.zeminListele(J10);
        }

        private void click_zemin(object sender, EventArgs e)
        {
            taslar.secim(sender);
        }

        private void A10_MouseDown(object sender, MouseEventArgs e)
        {

            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void B10_MouseDown(object sender, MouseEventArgs e)
        {


            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B10;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B10;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C10_MouseDown(object sender, MouseEventArgs e)
        {

            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C10;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C10;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D10_MouseDown(object sender, MouseEventArgs e)
        {

            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D10;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D10;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E10_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E10;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;

                }
            }
        }
        private void F10_MouseDown(object sender, MouseEventArgs e)
        {

            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G10_MouseDown(object sender, MouseEventArgs e)
        {

            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H10_MouseDown(object sender, MouseEventArgs e)
        {


            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I10_MouseDown(object sender, MouseEventArgs e)
        {


            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void J10_MouseDown(object sender, MouseEventArgs e)
        {



            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J10;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J10;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D9;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void J9_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J9;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J9;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }


        private void A8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void J8_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J8;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J8;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J7_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J7;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J7;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A6;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A6;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B6;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B6;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C6;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C6;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D6;
                    

                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D6;
                    

                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                eskiPb.Image = null;
                sayac++;
                if (sayac == 8)
                {
                    MessageBox.Show("Tebrikler, kazandınız!");
                    Environment.Exit(0);
                }
            }
        }
        private void F6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F6;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F6;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G6;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G6;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H6;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H6;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I6;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I6;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J6_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J6;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J6;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J5_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J5;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J5;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J4_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J4;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J4;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J3_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J3;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J3;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J2_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J2;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J2;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }



        private void A1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = A1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = B1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = C1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void D1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = D1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void E1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = E1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void F1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = F1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void G1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = G1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void H1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = H1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }
        private void I1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = I1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }

        }
        private void J1_MouseDown(object sender, MouseEventArgs e)
        {
            if (taslar.hareketHesapla((PictureBox)sender, eskiPb) == true)
            {
                if (seciliOlan == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J1;
                    
                }
                else if (seciliOlan.Image == null)
                {
                    seciliOlan = (PictureBox)sender;
                    eskiPb = J1;
                    
                }
                else
                {
                    ((PictureBox)sender).Image = seciliOlan.Image;
                    seciliOlan.Image = null;
                    seciliOlan = null;
                }
            }
        }

       
    }
}

 
