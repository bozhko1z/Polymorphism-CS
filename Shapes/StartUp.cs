using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(6, 8);

            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter():f2} / Area: {circle.CalculateArea():f2}");
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()} / Area: {rectangle.CalculateArea()}");
        }
    }
}
