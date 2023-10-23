using System;

namespace Calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Ошибка: неверное количество аргументов. Используйте формат: num1 оператор num2");
                    return;
                }

                double num1, num2;
                string operand;

                if (!double.TryParse(args[0], out num1))
                {
                    Console.WriteLine("Ошибка: первый аргумент не является числом.");
                    return;
                }

                operand = args[1];

                if (!double.TryParse(args[2], out num2))
                {
                    Console.WriteLine("Ошибка: третий аргумент не является числом.");
                    return;
                }

                Calc calc = new Calc();
                Console.WriteLine(calc.Calculate(num1, num2, operand));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}