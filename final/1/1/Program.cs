using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static bool palindrom(string word)
        {
            int a = 0;
            int b = word.Length - 1;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[b])
                {
                    return false;
                }
                b--;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] word = a.Split(' ');
            int cntword = 0;
            Console.WriteLine(word.Length);
            for (int i = 0; i < word.Length; i++)
            {
                if (palindrom(word[i]) == true)
                    cntword++;
            }
            Console.WriteLine(cntword);
            Console.ReadKey();
        }
    }
}
