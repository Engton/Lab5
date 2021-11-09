using System;
using System.Drawing;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Введите координату x точки A: ");
                int x = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Введите координату y точки A: ");
                int y = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите длину стороны квадрата: ");
                int sidelength = Int32.Parse(Console.ReadLine());
                Point p1 = new Point(x, y);

                Console.WriteLine("Выберите действие, которое хотите сделать, введя букву: m - перемещение, r - поворот: ");
                if (Console.ReadLine() == "m" || Console.ReadLine() == "M")
                {
                    SquareMoving squareMoving = new SquareMoving(p1, sidelength);

                    bool f = false;
                    switch (f)
                    {
                        case false:
                            {
                                Console.WriteLine("Введите в какую сторону выполнить перемещение : A - влево, D - вправо. Чтобы выйти из программы введите q");

                                if (Console.ReadLine() == "q" || Console.ReadLine() == "Q")
                                {
                                    break;
                                }
                                squareMoving.Move(Console.ReadLine());
                                goto case false;
                            }
                    }
                }
                else if (Console.ReadLine() == "r" || Console.ReadLine() == "R")
                {
                    SquareRotation squareRotation = new SquareRotation(p1, sidelength);

                    bool f = false;
                    switch (f)
                    {
                        case false:
                            {
                                Console.WriteLine("Введите в какую сторону выполнить поворот : A - влево, D - вправо. Чтобы выйти из программы введите q");

                                if (Console.ReadLine() == "q" || Console.ReadLine() == "Q")
                                {
                                    break;
                                }
                                squareRotation.Move(Console.ReadLine());
                                goto case false;
                            }
                    }
                }
                else return;
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    } 
}
