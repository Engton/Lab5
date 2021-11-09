using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_3
{
    public class IdentityMatrix : Matrix
    {
        int size;
        int sum = 0;
        int[,] ara;
        List<int> list = new List<int>();

        public override void InputMatrix()
        {
            Console.WriteLine($"Введите длинну и высоту матрицы(одно число): ");
            size = int.Parse(Console.ReadLine());
            ara = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        ara[i, j] = 1;
                    }
                    else
                    {
                        ara[i, j] = 0;
                    }
                }
            }
        }

        public override void DisplayMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(ara[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
