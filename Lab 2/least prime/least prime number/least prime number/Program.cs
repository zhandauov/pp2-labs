using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lpm
{
    class Program
    {
        public static bool Prime(int a)
        {
            if (a == 1)
                return false;
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string b = File.ReadAllText(@"C:/Users/acer/Desktop/lab_pp2/input.txt");
            string[] a = b.Split(' ');
            int min = int.Parse(a[0]);
            for (int i = 0; i < a.Length; i++)
            {
                if (int.Parse(a[i]) < min && (Prime(int.Parse(a[i])) == true))
                    min = int.Parse(a[i]);

            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}