using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_5_1
{
    public class SquareMoving
    {
        Point a;
        Point b;
        Point c;
        Point d;

        public SquareMoving(Point A, int sidelength)
        {
            a = A;

            b.X = a.X + sidelength;
            b.Y = a.Y;

            c.X = a.X + sidelength;
            c.Y = a.Y - sidelength;

            d.X = a.X;
            d.Y = a.Y - sidelength;
            Console.WriteLine($"Координаты точек квадрата: точка A({a.X}, {a.Y}), точка B({b.X}, {b.Y}), точка C({c.X}, {c.Y}), точка D({d.X}, {d.Y})");
        }

        public virtual void Move(string direction)
        {
            if (direction == "A" || direction == "a")
            {
                a.X = a.X - 1;
                b.X = b.X - 1;
                c.X = c.X - 1;
                d.X = d.X - 1;
            }
            else if (direction == "D" || direction == "d")
            {
                a.X = a.X + 1;
                b.X = b.X + 1;
                c.X = c.X + 1;
                d.X = d.X + 1;
            }
            else
            {
                Console.WriteLine("Not valid input.");
            }

            Console.WriteLine($"Перемещение... Точка A({a.X}, {a.Y}), точка B({b.X}, {b.Y}), точка C({c.X}, {c.Y}), точка D({d.X}, {d.Y})");
        }
    }
}
