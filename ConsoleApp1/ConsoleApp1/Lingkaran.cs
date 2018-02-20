using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lingkaran : BangunDatar
    {
        double jari;

        public Lingkaran()
        {

        }

        public Lingkaran(double jari)
        {
            Jari = jari;
        }

        public double Jari { get => jari; set => jari = value; }

        public override double getKeliling()
        {
            return 2 * Jari * Math.PI;
        }

        public override double getLuas()
        {
            return Math.PI * Jari * Jari;
        }
    }
}
