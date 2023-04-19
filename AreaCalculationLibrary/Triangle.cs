using System;

namespace AreaCalculationLibrary
{
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Конструктор треугольника с тремя сторонами
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует!");
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными!");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Метод возвращаеющий площадь треугольника по трем сторонам
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Метод указывающий является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return Math.Pow(_a, 2) - (Math.Pow(_b, 2) + Math.Pow(_c, 2)) == 0 ||
                   Math.Pow(_b, 2) - (Math.Pow(_c, 2) + Math.Pow(_a, 2)) == 0 ||
                   Math.Pow(_c, 2) - (Math.Pow(_a, 2) + Math.Pow(_b, 2)) == 0;
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами:\nA = {_a}\nB = {_b}\nC = {_c}";
        }
    }
}
