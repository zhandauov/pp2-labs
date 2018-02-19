using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Program
    {
        static void MoveSnake()
        {
            while (Game.GameOver != true)
            {
                Game.Suicide();
                //Console.SetCursorPosition(0, 31);
                //Console.WriteLine("Score:" + Game.score);
               // Console.CursorVisible = false;
                switch (Game.direction)
                {
                    case 1:
                        Game.snake.Move(1, 0);
                        break;
                    case 2:
                        Game.snake.Move(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move(0, 1);
                        break;
                    case 4:
                        Game.snake.Move(0, -1);
                        break;
                }
                Game.Draw();             
                Thread.Sleep(Game.speed);
            }
        }



        public static void Main(string[] args)
        {
            
            Game.Init();
            Thread t = new Thread(MoveSnake);
            t.Start();
            while (!Game.GameOver)
            {
                Console.CursorVisible = false;
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Game.direction == 3)                        
                        break;                        
                        Game.direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        if (Game.direction == 4)
                        break;
                        Game.direction = 3;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Game.direction == 1)
                            break;
                        Game.direction = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        if (Game.direction == 2)
                            break;
                        Game.direction = 1;
                        break;
                }

            }


        }
    }
}