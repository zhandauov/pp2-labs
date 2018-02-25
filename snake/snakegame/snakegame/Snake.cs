﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeExample
{
     class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;
        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();

            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
        }

        
        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');


            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            Suicide();
            CollisionWithWall();
            if (Eat())
            {
                if (Game.speed >= 30)
                {
                    Game.speed -= 2;
                    Game.score += 10;
                }
                Game.food.SetRandomPosition();
            }
        }

        public void Move2(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');


            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            Suicide();
            CollisionWithWall2();
            if (Eat())
            {
                if (Game.speed >= 30)
                {
                    Game.speed -= 2;
                    Game.score += 10;
                }
                Game.food.SetRandomPosition();
            }
        }

        public void Move3(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');


            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            Suicide();
            CollisionWithWall3();
            if (Eat())
            {
                if (Game.speed >= 30)
                {
                    Game.speed -= 2;
                    Game.score += 10;
                }
                Game.food.SetRandomPosition();
            }
        }

        public void Suicide()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    Game.GameOver = true;
                    break;
                }
                    
            }            
        }

        public void CollisionWithWall()
        {
            if (body[0].x > 69)
                body[0].x = 0;
            if (body[0].x < 0)
                body[0].x = 69;
            if (body[0].y > 29)
                body[0].y = 0;
            if (body[0].y < 0)
                body[0].y = 29;
        }

        public void CollisionWithWall2()
        {
            if (body[0].x == 69)
                Game.GameOver = true;
            if (body[0].x == 0)
                Game.GameOver = true;
            if (body[0].y == 29)
                Game.GameOver = true;
            if (body[0].y == 0)
                Game.GameOver = true;
        }

        public void CollisionWithWall3()
        {
            if (body[0].x == 69)
                Game.GameOver = true;
            if (body[0].x == 0)
                Game.GameOver = true;
            if (body[0].y == 29)
                Game.GameOver = true;
            if (body[0].y == 0)
                Game.GameOver = true;
            if (body[0].x == 22 && body[0].y >= 6 && body[0].y <= 25)
                Game.GameOver = true;
            if (body[0].x == 47 && body[0].y >= 6 && body[0].y <= 25)
                Game.GameOver = true;
        }

        public bool Eat()
        {
            if (body[0].x == Game.food.location.x
                && body[0].y == Game.food.location.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }
            return false;
        }


        public void Draw()
        {

            for (int i = 0; i < body.Count; i++)
            {
                /*if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;*/
                Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }

            /*          int index = 0;
                        foreach (Point p in body)
                        {
                            if (index == 0)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = color;
                            Console.SetCursorPosition(p.x, p.y);
                            Console.Write(sign);
                            index++;
                        }*/
        }
    }
}