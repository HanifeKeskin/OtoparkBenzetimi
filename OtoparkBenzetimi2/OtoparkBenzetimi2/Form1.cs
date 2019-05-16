using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkBenzetimi2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        BasitKuyruk bk = new BasitKuyruk(15);
        Yigit y = new Yigit(15);
        DaireselBagliListe dbl = new DaireselBagliListe(15);
        Araba araba = new Araba();
        Random rd = new Random();
        int sayi;
        private void btnGirisListe_Click(object sender, EventArgs e)
        {
           
            for (int i=0;i<15;i++)
            {
                bk.Insert(araba);
                araba.Renk1 = "Beyaz";
                lstGirisListesi.Items.Add("BİRİNCİ KAT--> " + "\nRenk:" + araba.Renk1);
            }
            for (int i = 0; i < 15; i++)
            {
                y.Push(araba);
                araba.Renk2 = "Siyah";
                lstGirisListesi.Items.Add("BODRUM  KAT --> " + "\nRenk:" + araba.Renk2);
            }
            for (int i = 0; i < 15; i++)
            {
                dbl.InsertFirst(araba);
                araba.Renk3 = "Kırmızı";
                lstGirisListesi.Items.Add("BODRUM  KAT --> " + "\nRenk:" + araba.Renk3);
            }
            
        }
        private void btnSecilenListele_Click(object sender, EventArgs e)
        {
            int Tur = Convert.ToInt32(txtTurSayisi.Text);
            sayi = rd.Next(0, 1);

            if (Tur<=15)
            {
                for (int i = 0; i < Tur; i++)
                {
                    araba = bk.Remove();
                    lstSecilenListe.Items.Add("Birinci Kat Silinen--> " + "\nRenk:" + araba.Renk1);
                }
                lstSecilenListe.Items.Add("Son Silenen Araba Beyaz "+ Tur.ToString()+"'dir");
            }
            
           else if(Tur<=30 && Tur>=16&& sayi==0)
            {
                for (int i = 0; i < Tur; i++)
                {
                    araba = y.Pop();
                    lstSecilenListe.Items.Add("Bodrum Kat Silinen--> " + "\nRenk:" + araba.Renk2);
                }
                lstSecilenListe.Items.Add("Son Silenen Araba Siyah " + Tur.ToString() + "'dir");

            }
            else if(Tur>30&&sayi==1)
            {
                for (int i = 0; i < Tur; i++)
                {
                    araba = dbl.DeleteFirst();
                    lstSecilenListe.Items.Add("İkinci Kat Silinen--> " + "\nRenk:" + araba.Renk3);
                }
                lstSecilenListe.Items.Add("Son Silenen Araba Kırmızı " + Tur.ToString() + "'dir");
            }

        }

      
    }
}
