using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManagerExample
{
    class Program
    {
        static void showFolderContent(DirectoryInfo cur, int pos)
        {
            FileSystemInfo[] data = cur.GetFileSystemInfos();
            for (int i = 0; i < data.Length; i++)
            {
                if (pos == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    
                }
                Console.WriteLine(data[i]);
            }

        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int pos = 0;

            DirectoryInfo dir = new DirectoryInfo(@"C:\Games");

            while (true)
            {
                if (pos == 0 || pos == dir.GetFileSystemInfos().Length - 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.Clear();

                showFolderContent(dir, pos);

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                            pos = dir.GetFileSystemInfos().Length - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos > dir.GetFileSystemInfos().Length - 1)
                            pos = 0;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                        }
                        else {
                            Console.Clear();
                            string p = f.FullName;
                            FileStream s = new FileStream(p, FileMode.Open, FileAccess.Read);
                            StreamReader r = new StreamReader(s);                           
                            Console.WriteLine(r.ReadToEnd());
                            Console.ReadKey();
                              }
                        break;
                    case ConsoleKey.Backspace:                      
                            dir = dir.Parent;                       
                        break;
                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }


        }
    }
}