using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class CalculadorIMC
    {
        public double Calcular(double peso, double altura)
        {
            if (altura <= 0)
            {
                throw new ArgumentException("A altura deve ser maior que zero.");
            }
            return peso / (altura * altura);
        }

        public string Classificar(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            if (imc >= 18.5 && imc < 24.9)
                return "Peso normal";
            if (imc >= 25 && imc < 29.9)
                return "Sobrepeso";
            return "Obesidade";
        }
    }
}
