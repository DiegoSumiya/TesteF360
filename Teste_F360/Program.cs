using System;
using Teste_F360.NovaPasta;

namespace Teste_F360
{
    class Program
    {
        static void Main(string[] args)
        {
            Klingon klingon = new Klingon();
            
            Console.WriteLine("Digite o texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("A quantidade de preposições no texto são de: " + klingon.GetPreposicoes(texto));
            Console.WriteLine();
            Console.WriteLine("A quantidade de verbos no texto são de: " + klingon.GetVerbos(texto));
            Console.WriteLine();
            Console.WriteLine("A quantidade de números bonitos são de: " + klingon.GetNumerosBonitos(texto));
        }
    }
}
