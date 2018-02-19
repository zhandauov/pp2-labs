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
            Console.SetWindowSize(70, 31);
            GameOver = false;
            direction = 1;
            speed = 100;

            snake = new Snake();
            food = new Food();
            wall = new Wall();
        }
        public static void Suicide()
        {
            for (int i = 1; i < snake.body.Count; i++)
            {
                if (snake.body[0].x == snake.body[i].x && snake.body[0].y == snake.body[i].y)
                    GameOver = true;
            }
            GameOver = false;
        }
        public static void Draw()
        {
            //Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }

        // serialize objects (Save function)
        // desiralize objects (Resume function)
    }
}