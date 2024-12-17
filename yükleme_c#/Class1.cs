using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace yükleme_c_
{
    internal class Class1
    {
        public double hesapla(int vize, int final, int odev)
        {
            double ortalama =(vize * 0.30) + (final *0.50)+(odev *0.20);
            return ortalama;
        }

    }
}
