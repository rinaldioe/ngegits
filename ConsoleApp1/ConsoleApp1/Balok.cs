using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Balok : PersegiPanjang
    {
        private int tinggi;

        public Balok():base()
        {
            Tinggi = 5;
        }

        public Balok(int panjang, int lebar,int tinggi) : base(panjang,lebar)
        {
            Tinggi = tinggi;
           
        }

        public int Tinggi { get => tinggi; set => tinggi = value; }

        
        public override int getLuas()
        {
            return Panjang * Panjang;
        }

        public int getVolume()
        {
           return Panjang * Lebar *Tinggi;
        }
    }
}
