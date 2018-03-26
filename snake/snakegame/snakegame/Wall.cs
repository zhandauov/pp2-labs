using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Wall
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Wall()
        {
            sign = '#';
            color = ConsoleColor.Magenta;
            body = new List<Point>();
           // LoadLevel(1);
        }

        public void LoadLevel(int level)
        {

            body.Clear();

            string fileName = string.Format(@"C:\Users\acer\Desktop\level1.txt", level);
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int row = 0;
            string line = "";
            while (row < 20)
            {
                line = sr.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '#')
                        body.Add(new Point(i, row));
                }
                row++;
            }
        }

        public void Serialization()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"C:\Users\acer\Desktop\lab pp2\snake\snakegame\savewall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, Game.wall);
            fs.Close();
        }

        public void Draw1()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i<70; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (i == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }

                    if (j == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }

                    if (i == 69)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }
                    
                    if (j == 30)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }
                }
            }
        }

        public void Draw2()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < 70; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (i == 22 && j >= 6 && j <= 25)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }
                    if (i == 47 && j >= 6 && j <= 25)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }
                    if (i == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }

                    if (j == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }

                    if (i == 69)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }

                    if (j == 30)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(sign);
                    }
                }
            }
        }
    }
}