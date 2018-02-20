using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class PersegiPanjang
    {
        protected readonly static int panjang=1;
        protected static int lebar;
        
        public PersegiPanjang()
        {
            panjang = 4;
            lebar = 6;
        }

        public PersegiPanjang(int panjang, int lebar)
        {
            Panjang = panjang;
            Lebar = lebar;
        }

        public int Panjang { get => panjang; set => panjang = value; }
        public int Lebar { get => lebar; set => lebar = value; }
        public int getKeliling(int panjang,int lebar)
        {
            return (panjang + lebar) * 2;
        }
        public int getKeliling()
        {
            return (this.panjang + this.lebar) * 2;
        }
        public virtual int getLuas()
        {
            return panjang * lebar;
        }
    }
}
