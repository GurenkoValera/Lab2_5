using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        bool found = false; // Флаг для отслеживания наличия комбинаций

        // Перебираем все возможные значения x, y, z
        for (int x = 1; x <= Math.Cbrt(N); x++)
        {
            for (int y = x; y <= Math.Cbrt(N); y++) // y >= x для уникальности комбинаций
            {
                for (int z = y; z <= Math.Cbrt(N); z++) // z >= y для уникальности комбинаций
                {
                    if (x * x * x + y * y * y + z * z * z == N)
                    {
                        Console.WriteLine($"Комбинация: x = {x}, y = {y}, z = {z}");
                        found = true;
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No such combinations!");
        }
    }
}
