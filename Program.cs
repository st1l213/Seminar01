using System;
using Study;

namespace Study
{
    public enum Align
    {
        center,
        left ,
        right
    } // перечисления выравнивания текста для метода Print

    public static class HelpFunctions // вспомогательные методы
    {
        public static void Print(string msg, Align align)
        {
          //Выравнивание текста по ценрту
            switch (align)
            {
                case Align.center:
                    Console.SetCursorPosition((Console.WindowWidth/2) - (msg.Length/2),Console.CursorTop);
                    Console.WriteLine(msg);
                    break;

                case Align.left:
                    Console.WriteLine(msg);
                    break;

                case Align.right:
                    Console.WriteLine(msg);
                    break;

            }
            Console.SetCursorPosition(0, Console.CursorTop);
        } 
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x,y);
                Console.WriteLine(msg);
        }
        public static void Print(string msg)
        { 
            Console.WriteLine(msg);
        }
        public static void Print(int value)
        {
            Console.WriteLine(value);
        }
        public static void Print(double value)
        {
            Console.WriteLine(value);
        }
        public static void Print(float value)
        {
            Console.WriteLine(value);
        }
        public static void Print(uint value)
        {
            Console.WriteLine(value);
        }
        public static void Print(long value)
        {
            Console.WriteLine(value);
        }
        public static void Print(decimal value)
        {
            Console.WriteLine(value);
        }
        public static void Print(short value)
        {
            Console.WriteLine(value);
        }

        public static void Pause()
        {
            Console.ReadLine();
        }
    }
}

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            inputInfo();
            Exchange();
            Vector();
            HelpFunctions.Print("Никита Денисов, Санкт-Петербург", Align.center);
            HelpFunctions.Pause();
        }
        
        /* Задание 1 и 2
         1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        а) используя склеивание;
        б) используя форматированный вывод;
        в) используя вывод со знаком $.*
       2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
     */
        static void inputInfo()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();

            int age;
            Console.WriteLine("Введите ваш возраст");
            do
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            while (age <= 0);

            Console.WriteLine("Введите ваш вес");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите ваш рост");
            float height = Convert.ToSingle(Console.ReadLine()) / 100;


            Console.WriteLine(name + " " + surname + " " + age + " " + weight + " " + height);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, weight, height);
            Console.WriteLine($"{name} {surname} {age} {weight} {height}");

            float bodyMassIndex = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ: {bodyMassIndex:f2}");
        }

        /* Задание 3
         * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
         * б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        */
        static void Vector()
        {
            HelpFunctions.Print("Введите координаты точек\n x1:");
            double x1 = Convert.ToInt32(Console.ReadLine());
            HelpFunctions.Print("y1:");
            double y1 = Convert.ToInt32(Console.ReadLine());
            HelpFunctions.Print("x2:");
            double x2 = Convert.ToInt32(Console.ReadLine());
            HelpFunctions.Print("y2:");
            double y2 = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Если число неточное,то будем использовать ~
            char equality = '~';
            if (distance == Convert.ToInt32(distance))
                equality = '=';

            HelpFunctions.Print($"Расстояние между двумя точками {equality} {distance}");
        }
       
        /* Задание 4
         * Написать программу обмена значениями двух переменных.
         * а) с использованием третьей переменной;
         * б) *без использования третьей переменной.
        */
        static void Exchange()
        {
            Console.WriteLine("Замена чисел \n Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
           
            /*С использоавнием 3-ей переменной
             int a = 133;
             int b = -4;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + " " + b);
            */
    }
    }

}
