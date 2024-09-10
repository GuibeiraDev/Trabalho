using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class TorresDeHanoi
    {
        public void Resolver(int n, char origem, char destino, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
                return;
            }

            Resolver(n - 1, origem, auxiliar, destino);
            Console.WriteLine($"Mover disco {n} de {origem} para {destino}");
            Resolver(n - 1, auxiliar, destino, origem);
        }
    }
}
