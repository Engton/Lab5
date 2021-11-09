using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_2
{
    public class Conoid: Cone
    {
        int radiusUpper;
        int radiusLower;
        int height;

        public Conoid()
        {
            Console.WriteLine($"Введите радиус нижнего основания конуса: ");
            radiusLower = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Введите радиус верхнего основания конуса: ");
            radiusUpper = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Введите высоту конуса: ");
            height = Int32.Parse(Console.ReadLine());
        }

        public override void VolumeAndSquare()
        {
            var volume = (height * (radiusUpper * radiusUpper + radiusUpper * radiusLower + radiusLower * radiusLower)) / 3;
            Console.WriteLine($"Объем усеченного конуса: {volume} пи");
        }
    }
}
