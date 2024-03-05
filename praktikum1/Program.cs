using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 10;
            //int b = 6;

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian  {0} * {1} = {2} ", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();


        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a-b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
       
        
            
    }
}