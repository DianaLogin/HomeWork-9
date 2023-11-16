using System;


namespace HomeWork_9
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //============================= Упражнение 10.1 ==============================

            string words = "ABCDEFU and your friends that I'll never see again";

            ACipher a_cipher = new ACipher();
            string a_1 = a_cipher.Encode(words); 
            string a_2 = a_cipher.Decode(a_1);

            BCipher b_cipher = new BCipher();
            string b_1 = b_cipher.Encode(words);    
            string b_2 = b_cipher.Decode(b_1);

            Console.WriteLine("Демонстрация работы класса ACipher :\n");
            Console.WriteLine($"Метод Encode : {a_1}");
            Console.WriteLine($"Метод Decode : {a_2}\n");

            Console.WriteLine("Демонстрация работы класса BCipher :\n");
            Console.WriteLine($"Метод Encode : {b_1}");
            Console.WriteLine($"Метод Decode : {b_2}\n");

            //========================== Домашнее задание 10.1 ============================


            Point point = new Point(Color.Green, Status.Visible);
            point.Go_Horizontal(55);
            point.Go_Vertical(77);
            point.Change_Color(Color.Yellow);
            point.Change_Visibility();
            point.Print();

            Circle circle = new Circle(10.00, Color.Purple, Status.Visible);
            circle.Go_Horizontal(10);
            circle.Go_Vertical(15);
            circle.Change_Color(Color.Blue);
            circle.Change_Visibility();
            Console.WriteLine($"Площадь окружности: {circle.Calculate_S()}");
            circle.Print();
            

            Rectangle rectangle = new Rectangle(Color.Blue, Status.Visible, 4.00, 7.06);
            rectangle.Go_Horizontal(200);
            rectangle.Go_Vertical(8);
            rectangle.Change_Color(Color.White);
            rectangle.Change_Visibility();
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Calculate_Ss()}");
            rectangle.Print();
            



        }
    }
}
