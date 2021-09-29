using System;
//решето Эратосфена
namespace PR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество чисел");
            int n = int.Parse(Console.ReadLine());
            bool[] mass = new bool[n];
            Console.WriteLine("Последовательность чисел: ");
            for (int i = 0; i < n; i++)
            {
                mass[i] = true;
                Console.Write("{0} ", i);
            }
            for (int p = 2; p < n; p++)
            {
                if (mass[p])
                {
                    for (int i = p * p; i < n; i += p)
                    {
                        mass[i] = false;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Простые числа: ");
            for (int i = 2; i < n; i++)
            {
                if (mass[i])
                    Console.Write("{0} ", i);
            }
        }
    }
}
