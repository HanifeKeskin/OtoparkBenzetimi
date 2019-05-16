using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkBenzetimi2
{
    public interface IYigit
    {
        void Push(Araba a);
        Araba Pop();
        Araba Peek();
        Boolean IsEmpty();
        int Top { get; set; }
    }
}
