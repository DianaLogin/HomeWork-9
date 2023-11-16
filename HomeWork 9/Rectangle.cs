using System;

namespace HomeWork_9
{
    internal class Rectangle : Point
    {
        private double Length;
        private double Width;

        /// <summary>
        /// Конструктор класса Прямоугольник
        /// </summary>
        /// <param name="color"></param>
        /// <param name="status"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(Color color, Status status, double length, double width) : base(color, status)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Метод вычисления площади Прямоугольника
        /// </summary>
        /// <returns></returns>
        public double Calculate_Ss()
        {
            return Length * Width;
        }


        public override void Go_Vertical(int Y)
        {
            Console.WriteLine($"Прямоугольник передвинулся по вертикали на {Y} cm");
        }

        public override void Go_Horizontal(int X)
        {
            Console.WriteLine($"Прямоугольник передвинулся по горизонтали на {X} cm");
        }

        public override void Change_Color(Color another_Color)
        {
            Color = another_Color;
            Console.WriteLine($"Цвет прямоугольника изменен на {Color}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длина: {Length}, Ширина: {Width}\n");
        }

    }
}
