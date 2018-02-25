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
            while (Game.GameOver == false)
            {               
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

        static void MoveSnake2()
        {
            while (Game.GameOver == false)
            {
                switch (Game.direction)
                {
                    case 1:
                        Game.snake.Move2(1, 0);
                        break;
                    case 2:
                        Game.snake.Move2(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move2(0, 1);
                        break;
                    case 4:
                        Game.snake.Move2(0, -1);
                        break;
                }
                Game.Draw1();
                Thread.Sleep(Game.speed);
            }
        }

        static void MoveSnake3()
        {
            while (Game.GameOver == false)
            {
                switch (Game.direction)
                {
                    case 1:
                        Game.snake.Move3(1, 0);
                        break;
                    case 2:
                        Game.snake.Move3(-1, 0);
                        break;
                    case 3:
                        Game.snake.Move3(0, 1);
                        break;
                    case 4:
                        Game.snake.Move3(0, -1);
                        break;
                }
                Game.Draw2();
                Thread.Sleep(Game.speed);
            }
        }



        public static void Main(string[] args)
      {
           Console.WriteLine("Press 1 to select lvl");
           Console.WriteLine("Press 2 to load previous game");
           ConsoleKeyInfo btn = Console.ReadKey();
           switch (btn.Key)
           {
               case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("1 Lvl");
                    Console.WriteLine("2 Lvl");
                    Console.WriteLine("3 Lvl");
                    ConsoleKeyInfo buton = Console.ReadKey();
                    switch (buton.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Game.Init();
                            Thread th = new Thread(MoveSnake);
                            th.Start();
                            while (Game.GameOver == false)
                            {
                                Thread.Sleep(100);
                                Console.CursorVisible = false;
                                ConsoleKeyInfo butn = Console.ReadKey();
                                switch (butn.Key)
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
                                Console.Clear();
                                Console.WriteLine("Game Over");
                                Console.WriteLine("Score: " + Game.score);
                                Console.ReadKey();                           
                            break;


                        case ConsoleKey.D2:
                            Console.Clear();
                            Game.Init();
                            Thread thr = new Thread(MoveSnake2);
                            Game.wall.Draw1();
                            thr.Start();
                            while (Game.GameOver == false)
                            {
                                Thread.Sleep(100);
                                Console.CursorVisible = false;
                                ConsoleKeyInfo butn = Console.ReadKey();
                                switch (butn.Key)
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
                            Console.Clear();
                            Console.WriteLine("Game Over");
                            Console.WriteLine("Score: " + Game.score);
                            Console.ReadKey();
                            break;

                        case ConsoleKey.D3:
                            Console.Clear();
                            Game.Init();
                            Thread thre = new Thread(MoveSnake3);
                            Game.wall.Draw1();
                            thre.Start();
                            while (Game.GameOver == false)
                            {
                                Thread.Sleep(100);
                                Console.CursorVisible = false;
                                ConsoleKeyInfo butn = Console.ReadKey();
                                switch (butn.Key)
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
                            Console.Clear();
                            Console.WriteLine("Game Over");
                            Console.WriteLine("Score: " + Game.score);
                            Console.ReadKey();
                            break;
                    }      
                    break;
       }
     }
    }
   }