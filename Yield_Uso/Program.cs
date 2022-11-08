using System;
using System.Collections.Generic;

namespace Yield_Uso
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Carro> carros = GeradorDeCarros();

            foreach (var carro in carros)
            {
                if (carro.NumeroDeSerie > 5) break;

                Console.WriteLine(carro);
            }

            Console.ReadKey();
        }

        private static IEnumerable<Carro> GeradorDeCarros()
        {

            //var carros = new List<Carro>();
            Console.WriteLine("Passei por aqui");

            for (int i = 1; i <= 100; i++)
            {
                //carros.Add(new Carro(Guid.NewGuid(), i));
                yield return new Carro(Guid.NewGuid(), i);               
            }

            //return carros;

        }
    }

    public class Carro
    {
        public Guid Id { get; private set; }
        public int NumeroDeSerie { get; private set; }

        public Carro(Guid id, int numeroDeSerie)
        {
            Id = id;
            NumeroDeSerie = numeroDeSerie;
            Console.WriteLine($"Novo carro gerado! Número de série: {NumeroDeSerie}");
        }

        public override string ToString() => $"Carro Id:{Id} e {nameof(NumeroDeSerie)}: {NumeroDeSerie}";

    }
}
