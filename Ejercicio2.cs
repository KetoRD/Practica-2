using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido/a al menú! ");

            Console.WriteLine("1. Convertir grados Celsius a Fahrenheit ");
            Console.WriteLine("2. Convertir dólares a pesos dominicanos ");
            Console.WriteLine("3. Convertir metros a pies ");
            Console.WriteLine("4. Salir ");
            Console.WriteLine(" Escoje una opción: ");
            int consulta = Convert.ToInt32(Console.ReadLine());

            switch (consulta)
            {
                case 1:
                    Console.WriteLine("Conversor de grados Celsius a Farenheit");
                    Console.WriteLine("Ingrese los grados que desea convertir: ");
                    int gradoC = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Estos son los grados convertidos a Farenheit: ");
                    int gradoF = Convert.ToInt32(gradoC * 1.8) + 32;
                    Console.WriteLine(gradoF);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Conversor de dólares a pesos dominicanos");
                    Console.WriteLine("Ingrese la cantidad de dólares que desea convertir: ");
                    int losDolares = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("La tasa actual para la compra de dólares está actualmente en 57 pesos, por lo que, este" +
                                      " es el equivalente en pesos dominicanos: ");
                    int losPesos = Convert.ToInt32(losDolares * 57);
                    Console.WriteLine(losPesos);
                    Console.ReadKey();
                    break;
                case 3:

                    Console.WriteLine("Conversor de metros a pies");
                    Console.WriteLine("Ingrese los metros que desea convertir: ");
                    int losMetros = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Este es el resultado en pies: ");
                    int losPies = Convert.ToInt32(losMetros * 3.28);
                    Console.WriteLine(losPies);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Hasta luego! ");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
