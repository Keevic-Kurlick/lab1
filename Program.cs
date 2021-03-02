using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    class Program
    {
        static void M2(float x)
        {
            try
            {

                float b = checked((float)Math.Log(Math.E, x));
                Console.WriteLine("ln({0}) = {1}", x, b);
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("Возникло арифметическое исключение");
            }
            Console.WriteLine("Проверка на арифметическое соответствие завершена\n");
        }

        static void M1(float x)
        {
            try
            {

                UUsh ush = new UUsh(x);

                Console.WriteLine(ush.VvodArg());
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Возникла ошибка: {0}", outOfRange.Message);
            }

            Console.WriteLine("\nПроверка на соответствие диапазону завершена\n");
        }
        static void Main()
        {
            float y;

            Console.WriteLine("Введите значение аргумента: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out float x))
            {
                y = (float)(Math.Log(Math.E, x));
                Console.WriteLine("ln({0}) = {1}", x, y);

            }
            else
                Console.WriteLine("Некорректный ввод\n");
            M1(x);
            M2(x);
            Console.WriteLine("Проверка на соответствие типу данных завершена\n");
        }

    }
    class UUsh
    {
        private float x;
        public UUsh(float X)
        {

            if ((X <= 0) || (X > 1.5))
            {
                throw new ArgumentOutOfRangeException("x", "аргумент должен принадлежать диапазону (0;1,5}");
            }
            else
            {

                x = X;
            }

        }
        public string VvodArg()
        {
            string arg = x.ToString();
            return (arg);
        }

    }

}
