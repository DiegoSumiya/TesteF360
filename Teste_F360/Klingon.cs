using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_F360.NovaPasta
{
    public class Klingon
    {
        public char[] foo = { 's', 'l', 'f', 'w', 'k' };
        public char[] bar = { 'b', 'c', 'd', 'g', 'h', 'j', 'm', 'n', 'p', 'q', 'r', 't', 'v', 'x', 'y', 'z' };
        public char[] alfabetoKlingon = { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };

        public int GetPreposicoes(string texto)
        {
            int qtd = 0;
            foreach (var palavra in texto.Split(" "))
            {
                var ultima = palavra[palavra.Length - 1];
                if (palavra.Length == 3 && !foo.Contains(ultima) && !palavra.Contains("d"))
                {
                    qtd++;
                }
            }
            return qtd;
        }

        public int GetVerbos(string texto)
        {
            int verbo = 0;
            int primeiraPessoa = 0;

            foreach (var palavra in texto.Split(" "))
            {
                var primeira = palavra.FirstOrDefault();
                var ultima = palavra[palavra.Length - 1];

                if (palavra.Length >= 8 && foo.Contains(ultima))
                {
                    verbo++;

                    if (bar.Contains(primeira))
                    {
                        primeiraPessoa++;
                    }
                }
            }

            return verbo;
        }

        public int GetNumerosBonitos(string texto)
        {
            int qtdeNumerosBonitos = 0;
            foreach (var palavra in texto.Split(" "))
            {
                long numero = 0;
                long peso = 1;
                foreach (var letra in palavra)
                {
                    numero += Array.IndexOf(alfabetoKlingon, letra) * peso;
                    peso *= 20;
                }
                if (numero >= 440566 && numero % 3 == 0)
                {
                    qtdeNumerosBonitos++;
                }
            }
            return qtdeNumerosBonitos;
        }
    }
}
