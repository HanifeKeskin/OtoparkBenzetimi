using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBenzetimi
{
    public class OncelikliKuyruk:IKuyruk
    {
       
        private Araba[] Kuyruk;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public OncelikliKuyruk(int size)
        {
            this.size = size;
            Kuyruk = new Araba[size];
        }
        public void Insert(Araba a)
        {
            if (count == size)
            {
                throw new Exception("Kuyruk Dolu.");
            }

            if (IsEmpty())
            {
                front++;
                Kuyruk[front] = a;
                count++;
            }
            else
            {
                int i;
               
                for (i = count - 1; i >= 0; i--)
                {
                    if (a.IslemSuresi > Kuyruk[i].IslemSuresi)
                        Kuyruk[i + 1] = Kuyruk[i];
                    else
                        break;
                }
                Kuyruk[i + 1] =a;
                front++;
                count++;
            }
        }

        public Araba Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Kuyruk Boş.");
            }
            Araba temp = Kuyruk[front];
            Kuyruk[front] = null;
            front--;
            count--;
            return temp;
        }

        public Araba Peek()
        {
            return Kuyruk[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
