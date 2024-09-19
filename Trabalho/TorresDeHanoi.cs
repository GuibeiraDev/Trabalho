using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Trabalho
{
    public class TorresDeHanoi
    {
        private static int movimentos;

        public static void Resolver(int n, char origem, char destino, char auxiliar)
        {
            if (n == 1)
            {
                movimentos++;
                Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
                return;
            }

            Resolver(n - 1, origem, auxiliar, destino);
            movimentos++;
            Console.WriteLine($"Mover disco {n} de {origem} para {destino}");
            Resolver(n - 1, auxiliar, destino, origem);
        }

        public static int ObterMovimentos()
        {
            return movimentos;
        }

        public static void ResetMovimentos()
        {
            movimentos = 0;
        }
    }
}

