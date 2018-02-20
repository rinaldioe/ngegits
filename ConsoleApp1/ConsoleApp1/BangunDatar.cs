using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class BangunDatar
    {
        public abstract double getKeliling();
        public abstract double getLuas();
        public String Keterangan()
        {
            return "Bangun datar punya luas dan keliling";
        }
    }
}
