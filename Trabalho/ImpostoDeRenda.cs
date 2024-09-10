using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class ImpostoRenda
    {
        // Método para calcular o imposto de renda com base no salário anual
        public double Calcular(double salarioAnual)
        {
            double imposto;

            if (salarioAnual <= 22847.76)
            {
                imposto = 0;
            }
            else if (salarioAnual <= 33919.80)
            {
                imposto = (salarioAnual - 22847.76) * 0.075;
            }
            else if (salarioAnual <= 45012.60)
            {
                imposto = (salarioAnual - 33919.80) * 0.15 + 828.39;
            }
            else if (salarioAnual <= 55976.16)
            {
                imposto = (salarioAnual - 45012.60) * 0.225 + 2104.99;
            }
            else
            {
                imposto = (salarioAnual - 55976.16) * 0.275 + 3920.24;
            }

            return imposto;
        }
    }
}

