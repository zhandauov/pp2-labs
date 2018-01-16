using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {
        public string name;
        public string sname;
        public int age;
        public double gpa;
        public string univ;

        public Student()
        {
            name = "Zhangir";
            sname = "Zhandauov";
            age = 17;
            gpa = 4;
        }
        public Student(string a, string b, int f, double d)
        {
            name = a;
            sname = b;
            age = f;
            gpa = d;
        }


        public override string ToString()
        {
            return sname + " " + name + " " + age + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student b = new Student("Zhanga", "Zhandauov", 17, 1.11);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
