using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci ogr = new Ogrenci();
            //Console.Read();

            string blg,isim,soyisim,meslek;
            int yasi;
            Console.Write("Adı: ");
            isim = Console.ReadLine();
            Console.Write("Soyadı: ");
            soyisim = Console.ReadLine();
            Console.Write("Mesleğiniz: ");
            meslek = Console.ReadLine();
            Console.Write("Yaşınız: ");
            yasi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Olduğunuz Kurum: ");
            blg = Console.ReadLine();
            Ogrenci ogr = new Ogrenci(blg,isim,soyisim,meslek,yasi);
            Console.Read();
        }
    }
}
