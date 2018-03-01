using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

namespace product
{
    public class Product
    {
        string name;
        int count;
        double price;
        public Product ()
        {
            name = "Lays";
            count = 200;
            price = 390.50;
        }
        public Product (string n, int c, double p)
        {
            name = n;
            count = c;
            price = p;
        }
        public override string ToString()
        {
            return name + " " + count + " " + price;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Product pr = new Product();
            FileStream fs = new FileStream(@"C:\Users\acer\Desktop\product\pr1.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Product));
            try
            {
                xs.Serialize(fs, pr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
                {
                fs.Close();                
                }

            FileStream fs1 = new FileStream(@"C:\Users\acer\Desktop\product\pr1.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs1 = new XmlSerializer(typeof(Product));
            try
            {
                Product pr1 = xs.Deserialize(fs) as Product;
                Console.WriteLine(pr1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs1.Close();
            }
            Console.ReadKey();
        }
    }
}
