using System;


namespace HomeWork_9
{
    enum Color
    {
        Blue,
        Green,
        Yellow,
        Purple,
        White
    }

    enum Status
    {
        Visible,
        Invisible
    }
    internal abstract class Figure : IDoSomething
    {
        protected Color Color { get; set; }
        protected Status Status { get; set; }

        protected Figure(Color color, Status status) 
        {
            Color = color;
            Status = status;
        }

        
        /// <summary>
        /// Метод передвижения по горизонтали
        /// </summary>
        /// <param name="X"></param>
        public virtual void Go_Horizontal(int X)
        {
            Console.WriteLine($"Фигура передвинулась по горизонтали на {X} cm");
        }

        /// <summary>
        /// Метод передвижения по вертикали
        /// </summary>
        /// <param name="Y"></param>
        public virtual void Go_Vertical(int Y)
        {
            Console.WriteLine($"Фигура передвинулась по вертикали на {Y} cm");
        }

        /// <summary>
        /// Метод изменения цвета
        /// </summary>
        /// <param name="another_Color"></param>
        public virtual void Change_Color (Color another_Color)
        {
            Color = another_Color;
            Console.WriteLine($"Цвет фигуры изменен на {Color}");
        }

        /// <summary>
        /// Метод изменения состояния фигуры с опросом состояния (тернарный оператор)
        /// </summary>
        public void Change_Visibility()
        {
            Status status = Status.Invisible;
            Console.WriteLine($"Фигура стала теперь {(status == Status.Visible ? "видимой" : "невидимой")}");
        }

        /// <summary>
        /// Метод вывода на экран
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"Цвет: {Color}, \t\nСостояние: {Status}");
        }

    }
}
