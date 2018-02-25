using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
        class Game
    {

        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public static bool GameOver;
        public static int direction;
        public static int speed;
        public static int score = 0;
        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(90, 40);
            GameOver = false;
            direction = 1;
            speed = 100;

            snake = new Snake();
            food = new Food();
            wall = new Wall();
        }
        public static void Draw()
        {            
            snake.Draw();
            food.Draw();
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("score: " + score);
        }

        public static void Draw1()
        {           
            wall.Draw1();
            snake.Draw();
            food.Draw();
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("score: " + score);
        }

        public static void Draw2()
        {
            wall.Draw2();
            snake.Draw();
            food.Draw();
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("score: " + score);
        }
    }
}