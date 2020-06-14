using System;

namespace zadanie3
{
    class Program
    {

        static int ReadNumber(string invitation, int minValue, int maxValue) // Проверка корректности ввода числа
        { //Отбирает только целые числа в границах от minValue до maxValue
            bool ok;
            int value;
            do
            {
                Console.WriteLine(invitation);
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out value);
                if (!ok || value < minValue || value > maxValue)
                    Console.WriteLine($"Неправильный формат ввода. Пожалуйста, введите число от {minValue} до {maxValue}");
            } while (!ok || value < minValue || value > maxValue);
            return value;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());

            if ((y>=x-1 && y<=x+1 && y <=-x+1 && y >=-x-1 ))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
