using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
    class Food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;

        public Food()
        {
            color = ConsoleColor.Green;
            sign = '@';
            location = new Point(20, 10);
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(2, 68);
            int y = new Random().Next(2, 28);
            for (int i = 0; i < Game.snake.body.Count; i++)
            {
                if (x == Game.snake.body[i].x && y == Game.snake.body[i].y && (x == 22 && y >= 6 && y <= 25) && (x == 47 && y >= 6 && y <= 25))
                {
                    x = new Random().Next(2, 68);
                    y = new Random().Next(2, 28);                  
                }
            }        
            location = new Point(x, y);
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}