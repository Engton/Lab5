using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_5_1
{
    public class SquareRotation : SquareMoving
    {
        Point a;
        Point b;
        Point c;
        Point d;
        public SquareRotation(Point A, int sidelength) : base(A, sidelength)
        {
            a = A;

            b.X = a.X + sidelength;
            b.Y = a.Y;

            c.X = a.X + sidelength;
            c.Y = a.Y - sidelength;

            d.X = a.X;
            d.Y = a.Y - sidelength;
        }

        public override void Move(string direction)
        {
            if (direction == "A" || direction == "a")
            {
                b.Y = b.Y + 1;

                c.X = c.X + 1;
                c.Y = c.Y + 1;

                d.X = d.X + 1;
            }
            else if (direction == "D" || direction == "d")
            {
                b.Y = b.Y - 1;

                c.X = c.X - 1;
                c.Y = c.Y - 1;

                d.X = d.X - 1;
            }
            else
            {
                Console.WriteLine("Not valid input.");
            }

            Console.WriteLine($"Поворот... Точка A({a.X}, {a.Y}), точка B({b.X}, {b.Y}), точка C({c.X}, {c.Y}), точка D({d.X}, {d.Y})");
        }
    }
}
