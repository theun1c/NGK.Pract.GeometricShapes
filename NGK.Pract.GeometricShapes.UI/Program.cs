using NGK.Pract.GeometricShapes.Model;
using System.Diagnostics;

namespace NGK.Pract.GeometricShapes.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 10;
            var pl = circle.Ploshad();
            Debug.WriteLine("площадь круга - " + pl);
            Debug.Assert(pl < 0, "площадь должна быть положительной");
            Console.WriteLine(pl);
        }
    }
}
