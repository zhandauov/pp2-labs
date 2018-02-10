using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex
{
    class complex
    {
        public int a, b;
        public complex(int c, int d)
        {
            a = c;
            b = d;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex c3 = new complex(0, 0);
            c3.a = c1.a * c2.b + c2.a * c1.b;
            c3.b = c1.b * c2.b;
            return c3;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        class Program
        {
            static void Main(string[] args)
            {
                int a = 9;
                int b = 3;
                int c = 4;
                int d = 2;
                complex c1 = new complex(a, b);
                complex c2 = new complex(c, d);
                complex c3 = c1 + c2;
                for (int i = 1; i <= c3.a; i++)
                    if (c3.a % i == 0 && c3.b % i == 0)
                    {
                        c3.a = c3.a / i;
                        c3.b = c3.b / i;
                    }
                Console.WriteLine(c3);
                Console.ReadKey();
            }
        }
    }
}
