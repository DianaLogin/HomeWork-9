using System;

namespace HomeWork_9
{
    internal class Circle : Point
    {
        private double Radius;

        /// <summary>
        /// Конструктор класса Окружность
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        /// <param name="status"></param>
        public Circle(double radius, Color color, Status status) : base(color, status)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод вычисления площади окружности
        /// </summary>
        /// <returns></returns>
        public double Calculate_S()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Go_Vertical(int Y)
        {
            Console.WriteLine($"Окружность передвинулась по вертикали на {Y} cm");
        }

        public override void Go_Horizontal(int X)
        {
            Console.WriteLine($"Окружность передвинулась по горизонтали на {X} cm");
        }

        public override void Change_Color(Color another_Color)
        {
            Color = another_Color;
            Console.WriteLine($"Цвет окружности изменен на {Color}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {Radius}\n");
        }
    }
}

