using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBenzetimi2
{
    public class Yigit:IYigit
    {
        public int Top { get; set; }
        private Araba[] yigit;
        private int front = -1;
        private int size = 0;
        public Yigit(int size)
        {
            this.size = size;
            yigit = new Araba[size];
        }
        public void Push(Araba a)
        {
            if (size==Top)
                throw new Exception("Yığıt Dolu.");

            if (Top == -1)
                Top = 0;

            yigit[++front] = a;
            Top++;
        }

        public Araba Pop()
        {
            if (IsEmpty())
                throw new Exception("Yığıt boş.");

            Araba temp= yigit[front];
            yigit[front] = null;
            front--;
            Top--;
            return temp;
        }

        public Araba Peek()
        {
            return yigit[front];
        }

        public bool IsEmpty()
        {
            return (Top == 0);
        }
    }
}
