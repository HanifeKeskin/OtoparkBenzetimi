using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkBenzetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float[] Dizi = new float [10];
        BasitKuyruk bk = new BasitKuyruk(10);
        OncelikliKuyruk ok = new OncelikliKuyruk(10);
        private void btnListele_Click(object sender, EventArgs e)
        { 
            
             if (cmbKuyrukTipi.Text=="Basit Kuyruk Yapısı")
            {
                Random rd = new Random();
                 for (int i = 0; i < 10; i++)
                {
                    Araba araba = new Araba();
                    araba.IslemSuresi = rd.Next(10, 300);
                    araba.OtoparkNo = i + 1;

                    bk.Insert(araba);
               }
              float ortalamaIslemSure = 0;
              int toplamSure = 0;
              for (int i=0;i<10;i++)
                {
                    Araba araba = new Araba();
                    araba = bk.Remove();
                    ok.Insert(araba);

                    toplamSure += araba.IslemSuresi;
                    ortalamaIslemSure = toplamSure / (i + 1);

      lstListele.Items.Add("Otopark No:" + araba.OtoparkNo +"\tİşlem Süresi:" + araba.IslemSuresi + "\tToplam İşlem:"+ toplamSure + "\t Ortalama Sure : " + ortalamaIslemSure);

                    Dizi[i] =  ortalamaIslemSure;
                }
              
            }
            else if (cmbKuyrukTipi.Text == "Öncelikli Kuyruk Yapısı")
            {
                lstListele.Items.Clear();
                int toplamSure = 0;
                float ortbeklemeSure = 0;

                float fark = 0;
                float yuzdeFark = 0;
                   for (int i=0;i<10;i++)
                    {
                    Araba araba = new Araba();
                    araba = ok.Remove();

                    toplamSure += araba.IslemSuresi;
                    ortbeklemeSure = toplamSure / (i + 1);

                    fark = Dizi[araba.OtoparkNo - 1] - ortbeklemeSure;
                    yuzdeFark = 100 - (ortbeklemeSure * 100 / Dizi[araba.OtoparkNo - 1]);

 lstListele.Items.Add("Otopark No:" + araba.OtoparkNo + "\tİşlem Süresi:" + araba.IslemSuresi + "\tToplam İşlem:" + toplamSure + "\tOrtalama Sure:" + ortbeklemeSure + " \tFark:" + fark + "\tFark(%):" + yuzdeFark);
                    }
                }

            }

        private void cmbKuyrukTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

