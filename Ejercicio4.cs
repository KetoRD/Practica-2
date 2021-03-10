using System;

namespace salarioeimpuesto
{
    class Program
    {
        private static bool Main(string[] args)
        {
            Console.WriteLine("Hola!");
            Console.WriteLine("Escriba su nombre, por favor: ");
            string nombre = (Console.ReadLine());

            Console.WriteLine("Muy bien " + nombre);
            Console.WriteLine("Ahora, digíte su sueldo");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Su sueldo es de:" + s + " pesos");

            Console.WriteLine("El total a pagar por AFP es: ");
            int afp = (int)((s * 2.87) / 100);
            Console.WriteLine(afp);

            Console.WriteLine("El total a pagar por ARS es: ");
            int ars = (int)((s * 3.04) / 100);
            Console.WriteLine(ars);

            Console.WriteLine("En total, usted pago : " + (afp + ars) + " por AFP y ARS");


            int sueldoNormal = s - (afp + ars);
            int sueldoAnual = sueldoNormal * 12;

            if (sueldoAnual <= 416.220)
            {
                int irsF = (0);
                Console.WriteLine("El impuesto sobre la renta es de: " + irsF + " para un empleado que tenga un sueldo de " + s + " pesos mensuales");
                Console.ReadKey();
            }

            else if (sueldoAnual >= 416.201 && sueldoAnual <= 624.329)
            {
                int irsF = Convert.ToInt32((sueldoAnual * 15) / 100);
                Console.WriteLine("El impuesto sobre la renta es de: " + irsF + " para un empleado que tenga un sueldo de " + s + " pesos mensuales");
                Console.ReadKey();
            }

            else if (sueldoAnual >= 624.329 && sueldoAnual <= 867.123)
            {
                int irsF = Convert.ToInt32((sueldoAnual * 20) / 100) + 31216;
                Console.WriteLine("El impuesto sobre la renta es de: " + irsF + " para un empleado que tenga un sueldo de " + s + " pesos mensuales");
                Console.ReadKey();
            }

            else (sueldoAnual >= 867.124)
            {
                int irsF = Convert.ToInt32((sueldoAnual * 25) / 100) + 79776;
                Console.WriteLine("El impuesto sobre la renta es de: " + irsF + " para un empleado que tenga un sueldo de " + s + " pesos mensuales");
                Console.ReadKey();
            }




        }









    }
}
