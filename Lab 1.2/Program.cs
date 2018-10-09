using System;

namespace Lab_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Некорректный ввод. Необходимо вещественное число. В качестве разделителя используйте запятую.");
            }
            else
            {
                Console.WriteLine("Введите значение y:");
                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    Console.WriteLine("Некорректный ввод. Необходимо вещественное число. В качестве разделителя используйте запятую.");
                }
                else
                {
                    bool result = (x * x + y * y <= 1) && !(x < 0 && y < 0);
                    if (result)
                    {
                        Console.WriteLine($"Точка ({x}, {y}) принадлежит требуемой области");
                    }
                    else
                    {
                        Console.WriteLine($"Точка ({x}, {y}) не принадлежит требуемой области");
                    }
                }
                
            }
            Console.ReadLine();
        }
    }
}
