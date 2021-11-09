using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_3
{
    public class Matrix
    {
        int length;
        int height;
        int sum = 0;
        int[,] ara;

        public virtual void InputMatrix()
        {
            Console.Write("Введите длину матрицы: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту матрицы: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("\nЗаполнение матрицы\n");
            ara = new int[length, height];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("Введите число: ");
                    ara[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        public virtual void DisplayMatrix()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("{0} ", ara[i, j]);
                    sum += ara[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСумма матрицы = {0}", sum);
            Console.ReadKey();
        }
    }
}
