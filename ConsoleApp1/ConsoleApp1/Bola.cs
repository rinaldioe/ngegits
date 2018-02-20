using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bola : Lingkaran,BangunRuang
    {
        double BangunRuang.GetLuasPermukaaan()
        {
            throw new NotImplementedException();
        }

        double BangunRuang.GetVolume()
        {
            return Math.PI * Jari * Jari * Jari;
        }
    }
}
