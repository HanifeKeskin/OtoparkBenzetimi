using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBenzetimi
{
    public class BasitKuyruk:IKuyruk
    {
        private Araba[] Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public BasitKuyruk(int size)
        {
            this.size = size;
            Kuyruk = new Araba[size];
        }
        public void Insert(Araba a)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("Kuyruk Dolu.");

            if (front == -1)
                front = 0;

            Kuyruk[++rear] = a;
            count++;
        }

        public Araba Remove()
        {
            if (IsEmpty())
                throw new Exception("Kuyruk boş.");

            Araba temp = Kuyruk[front];
            Kuyruk[front] = null;
            front++;
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
