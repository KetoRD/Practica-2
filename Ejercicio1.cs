using System;

namespace Ejercicio1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];

            int a = 0;
            do
            {
                a++;
                Console.WriteLine("Escriba un numero: ");
                nums[a] = Convert.ToInt32(Console.ReadLine());
            } while (nums[a] != 0);

            Console.WriteLine("Estos son todos los numeros ingresados anteriormente: ");
            foreach (int b in nums)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
