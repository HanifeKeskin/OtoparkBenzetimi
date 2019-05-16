using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtoparkBenzetimi2
{
    public class DaireselBagliListe:IDaireselListe
    {
        public Dugum Head;
        public int size = 0;
        private int Top = 0;
        private Araba[] DaireselListe;

        public DaireselBagliListe(int size)
        {
            this.size = size;
            DaireselListe = new Araba[size];
        }
        public void InsertFirst(Araba a)
        {
            if (size==Top)
                throw new Exception("Dairesel Bağlı Liste Dolu.");

            Dugum tmpHead = new Dugum
            {
                Veri = a.Renk3
           
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            //size++;
            size++;
            Top++;
        }
        public void InsertLast(Araba a)
        {
            throw new NotImplementedException();
        }

        public Araba DeleteFirst()
        {
            if (IsEmpty())
                throw new Exception("Dairesel Bağlı Liste Boş.");
       // DaireselBagliListe dbl = new DaireselBagliListe(15);
         Araba temp = DaireselListe[size];
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Dugum HeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (HeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = HeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                //size--;
                size++;
                Top--;
            }
            return temp;

        }
        public  Araba DeleteLast()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return (Top == 0);
        }
        public Araba Peek()
        {
            return DaireselListe[size];
        }
        public Araba GetElement()
        {
            throw new NotImplementedException();
        }

        public Araba DisplayElements()
        {
            throw new NotImplementedException();
        }
       
    }
}
