using System;
using System.Linq;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inverter(string valor)
            {
                var reverseArray = valor.ToCharArray().Reverse().ToArray();
                return new string(reverseArray);
            }

            string texto;

            texto = "Utilizando o C#";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            texto = "Local Function";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            Console.ReadKey();
        }
    }
}
