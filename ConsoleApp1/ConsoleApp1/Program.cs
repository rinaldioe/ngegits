using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int panjang, lebar;
            int keliling, luas;
            String pilihan;

            PersegiPanjang persegiPanjang = new PersegiPanjang(10,5);
            Balok balok = new Balok();
            Balok balok2 = new Balok(10, 5, 3);
            
            Lingkaran lingkaran = new Lingkaran();
            
           // persegiPanjang.Lebar = 5;
           // persegiPanjang.Panjang = 10;
           
            Console.WriteLine(balok.getLuas());
            Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Masukkan panjang = ");
            //    panjang = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Masukkan lebar = ");
            //    lebar = Convert.ToInt32(Console.ReadLine());
            //    keliling = 2 * (panjang + lebar);
            //    luas = panjang * lebar;
            //    Console.WriteLine("Keliling = " + keliling);
            //    Console.WriteLine("Luas = " + luas);
            //    do
            //    {
            //        Console.WriteLine("Apakah anda ingin hitung lagi (Y/N) = ");
            //        pilihan = Console.ReadLine();
            //    } while (!pilihan.Equals("y", StringComparison.OrdinalIgnoreCase) && !pilihan.Equals("n", StringComparison.OrdinalIgnoreCase));
                
            //} while (pilihan.ToLower()=="y");

            //pilihan = Console.ReadLine();
        }
    }
}
