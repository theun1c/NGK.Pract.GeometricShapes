using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGK.Pract.GeometricShapes.Model
{
    /// <summary>
    /// Модель для круга
    /// TODO: методы для вычисления площади и периметра
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// конструктор, принимающий значение радиуса
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double Diameter => Radius * 2;  

        /// <summary>
        /// метод для подсчета периметра круга
        /// </summary>
        /// <returns></returns>
        public double Perimetr()
        {
            return Diameter * Math.PI;
        }

        /// <summary>
        /// метод для подсчета площади круга
        /// </summary>
        /// <returns></returns>
        public double Ploshad()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
