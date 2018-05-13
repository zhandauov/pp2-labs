using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2
{
    class Program
    {
        static bool isprime(int a)
        {
            if (a == 1 || a == 0)
                return false;
            if (a == 2)
                return true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\acer\Desktop\final\papka");
            FileInfo[] files = d.GetFiles();

            foreach (FileInfo a in files)
            {
                StreamReader sr = new StreamReader(a.FullName);
                string ss = sr.ReadLine();
                if (ss == "")
                    continue;

                string [] s = ss.Split(' ');
                for (int i = 0; i < s.Length; i++)
                {
                    if (isprime(int.Parse(s[i])) == true) {
                        Console.WriteLine(a.Name);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
