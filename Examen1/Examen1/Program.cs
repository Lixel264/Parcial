using System;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Dame un día de la semana.");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "viernes":
                    Console.WriteLine("Es fin de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;
                default:
                    Console.WriteLine("Lo siento, no ingresaste un día de la semana");
                    break;
            }
        }
    }
}
