using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, toplam, carpim, ortalama;

            Console.WriteLine("1.sayıyı girin");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayıyı girin");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4.sayıyı girin");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5.sayıyı girin");
            e = Convert.ToInt32(Console.ReadLine());

            toplam = a + b + c + d + e;
            carpim = a * b * c * d * e;
            ortalama = (a + b + c + d + e) / 5;

            Console.WriteLine("toplam:" + toplam + "\n" + "carpim:" + carpim + "\n" + "ortalama:" + ortalama + "\n");
            Console.Read();
        }
    }
}
