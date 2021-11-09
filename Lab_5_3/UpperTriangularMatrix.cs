using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_3
{
    public class UpperTriangularMatrix : Matrix
    {
        int length;
        int height;
        int sum = 0;
        int[,] ara;
        List<int> list = new List<int>();
        int n = 0;

        public override void InputMatrix()
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
                    int temp;
                    Console.Write("Введите число: ");
                    temp = int.Parse(Console.ReadLine());
                    ara[i, j] = temp;
                    list.Add(temp);
                }
            }
            Console.WriteLine();
        }

        public override void DisplayMatrix()
        {
            if (length == height)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (j >= i) ara[i, j] = list[n++];
                        else ara[i, j] = 0;
                        Console.Write("{0} ", ara[i, j]);
                        sum += ara[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nСумма матрицы = {0}", sum);
                Console.ReadKey();
            }
            else Console.WriteLine("Высота должна быть равна длинне");
        }
    }
}
