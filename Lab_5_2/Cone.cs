using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    public class Cone
    {
        int radius;
        int height;

        public Cone()
        {
            Console.WriteLine($"Введите радиус конуса: ");
            radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Введите высоту конуса: ");
            height = Int32.Parse(Console.ReadLine());
        }

        public virtual void VolumeAndSquare()
        {
            var volume = (radius * radius * height) / 3;
            Console.WriteLine($"Объем конуса: {volume} пи");

            var square = radius * radius;
            Console.WriteLine($"Площадь основания конуса: {square} пи");
        }
    }
}
