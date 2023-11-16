using System;


namespace HomeWork_9
{
    internal class Point : Figure
    {
        public Point(Color color, Status status) : base(color, status) { }
        
        public override void Go_Vertical(int Y)
        {
            Console.WriteLine($"Точка передвинулась по вертикали на {Y} cm");
        }

        public override void Go_Horizontal(int X) 
        {
            Console.WriteLine($"Точка передвинулась по горизонтали на {X} cm");
        }

        public override void Change_Color(Color another_Color)
        {
            Color = another_Color;
            Console.WriteLine($"Цвет точки изменен на {Color}");
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
