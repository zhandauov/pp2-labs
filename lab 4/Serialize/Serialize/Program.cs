using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Serialize
{
    [Serializable]
   public class complex
    {
        public int a, b;
        public complex(int c, int d)
        {
            a = c;
            b = d;
        }
        public complex()
        {
            a = 3;
            b = 4;
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
            static void f1()
            {
                FileStream fs = new FileStream(@"C:\Users\acer\Desktop\lab pp2\data.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(complex));
                complex c1 = new complex(4,5);
                try
                {
                    xs.Serialize(fs, c1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    fs.Close();
                }
                Console.WriteLine("done");
            }
            static void f2()
            {
                FileStream fs = new FileStream(@"C:\Users\acer\Desktop\lab pp2\data.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(complex));
                try
                {
                    complex c1 = xs.Deserialize(fs) as complex;
                    Console.WriteLine(c1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            static void Main(string[] args)
            {
                f1();
                f2();

                /*complex n = new complex(1, 2);
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"C:\Users\acer\Desktop\lab pp2\data2.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, n);
                stream.Close();

                IFormatter formatter1 = new BinaryFormatter();
                Stream streamReader = new FileStream(@"C:\Users\acer\Desktop\lab pp2\data2.xml", FileMode.Open, FileAccess.Read);
                complex n1 = (complex)formatter1.Deserialize(streamReader);
                streamReader.Close();*/

                Console.ReadKey();
            }
        }
    }
}