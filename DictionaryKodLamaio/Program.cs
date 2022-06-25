using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryKodLamaio
{
    class Program
    {
        static void Main(string[] args)
        {

            Kutuphane<int, string> isimler = new Kutuphane<int, string>();

            isimler.Ekle(0, "Mustafa");
            isimler.Ekle(1, "Elif");
        
            //eklemekte sıkıntı yok ama for veya foreach ile ekrana yazdıramıyorum.
        }
    }

    class Kutuphane<a, b>
    {
        a[] a_;
        b[] b_;


        public Kutuphane()
        {
            a_ = new a[0];
            b_ = new b[0];
        }


        public void Ekle(a key, b value)
        {
            a[] tempKey = a_;
            b[] tempValue = b_;

            a_ = new a[a_.Length + 1];
            b_ = new b[b_.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                a_[i] = tempKey[i];
                b_[i] = tempValue[i];

            }

            a_[a_.Length - 1] = key;
            b_[b_.Length - 1] = value;
        }
    }
}
