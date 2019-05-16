using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBenzetimi2
{
    public interface IDaireselListe
    {
        void InsertFirst(Araba a);
        void InsertLast(Araba a);
       Araba DeleteFirst();
       Araba DeleteLast();
        Araba Peek();
        Boolean IsEmpty();
        Araba DisplayElements();
        Araba GetElement();
    }
}
