using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi kalkulator";

            Console.Write("1.tambah \n");
            Console.Write("2.kurang \n");
            Console.Write("3.bagi \n");
            Console.Write("4.kali \n");

            Console.Write("masukan pilihan [1..4]: ");
            char pilih = char.Parse(Console.ReadLine());
            if (pilih > 4)
            {
                Console.WriteLine("pilihan gak ada");
                Console.WriteLine("tekan sembarang untuk keluar");
                Console.ReadKey();
                Console.ReadKey();
                return;
            }
            Console.Write("masukan anggka pertama: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("masukan anggka kedua: ");
            int b = int.Parse(Console.ReadLine());
            switch (pilih)
            {
                case '1':
                    Console.WriteLine  ("hasil penjumlahan " + a + '+' + b + '=' + tambah(a, b));
                    break;
                case '2':
                    Console.WriteLine("hasil pengurangan " + a + '-' + b + '=' + kurang(a, b));
                    break;
                case '3':
                    Console.WriteLine("hasil pembagian " + a + ':' + b + '=' + bagi(a, b));
                    break;
                case '4':
                    Console.WriteLine("hasil perkalian " + a + 'x' + b + '=' + kali(a, b));
                    break;
            }
            Console.WriteLine  ("tekan sembarang untuk keluar");
            Console.ReadKey();
            Console.ReadKey();
        }

        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static float bagi(float a, float b)
        {
            return a / b;
        }
    }
}
