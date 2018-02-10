using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = File.ReadAllText(@"C:/Users/acer/Desktop/lab_pp2/max min/input.txt");
            string[] a = b.Split(' ');
            int max = int.Parse(a[0]);
            int min = int.Parse(a[0]);
            for (int i = 0; i < a.Length; i++)
            {
                if (int.Parse(a[i]) > max)
                    max = int.Parse(a[i]);
                if (int.Parse(a[i]) < min)
                    min = int.Parse(a[i]);

            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}