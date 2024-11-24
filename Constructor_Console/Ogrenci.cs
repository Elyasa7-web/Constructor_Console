using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Console
{
    internal class Ogrenci
    {
        //public Ogrenci()
        //{
        //    Console.WriteLine("Adı: Elyasa");
        //    Console.WriteLine("Soyadı: Kapucu");
        //    Console.WriteLine("Mesleği: Yazılım Mühendisi");


        public Ogrenci(string bilgi, string isim,string soyisim,string meslek,int yasi) 
        {
            Console.WriteLine("Ad: " + isim);
            Console.WriteLine("Soy Ad: "+ soyisim);
            Console.WriteLine("Mesleğiniz: "+ meslek);
            Console.WriteLine("Yaşınız: " + yasi);
            Console.WriteLine("Olduğunuz Kurum: " + bilgi);
        }
    }
}
