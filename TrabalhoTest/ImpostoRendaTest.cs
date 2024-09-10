using Trabalho;

namespace ImpostoDeRendaTest
{
    [TestClass]
    public class ImpostoRendaTest
    {
        [TestMethod]
        public void Calcular_SalarioAbaixoLimiteTest()
        {
            // Cenário
            double salarioAnual = 22000.00;
            double impostoEsperado = 0;
            ImpostoRenda impostoRenda = new ImpostoRenda();

            // Ação
            double impostoCalculado = impostoRenda.Calcular(salarioAnual);

            // Verificação
            if (impostoCalculado == impostoEsperado)
            {
                Console.WriteLine("Teste Calcular_SalarioAbaixoLimiteTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Calcular_SalarioAbaixoLimiteTest: Falhou");
            }
        }

        [TestMethod]
        public void Calcular_SalarioDentroFaixa075Test()
        {
            // Cenário
            double salarioAnual = 30000.00;
            double impostoEsperado = (30000.00 - 22847.76) * 0.075;
            ImpostoRenda impostoRenda = new ImpostoRenda();

            // Ação
            double impostoCalculado = impostoRenda.Calcular(salarioAnual);

            // Verificação
            if (Math.Abs(impostoCalculado - impostoEsperado) < 0.01)
            {
                Console.WriteLine("Teste Calcular_SalarioDentroFaixa075Test: Passou");
            }
            else
            {
                Console.WriteLine("Teste Calcular_SalarioDentroFaixa075Test: Falhou");
            }
        }

        [TestMethod]
        public void Calcular_SalarioAcimaFaixa275Test()
        {
            // Cenário
            double salarioAnual = 60000.00;
            double impostoEsperado = (60000.00 - 55976.16) * 0.275 + 3920.24;
            ImpostoRenda impostoRenda = new ImpostoRenda();

            // Ação
            double impostoCalculado = impostoRenda.Calcular(salarioAnual);

            // Verificação
            if (Math.Abs(impostoCalculado - impostoEsperado) < 0.01)
            {
                Console.WriteLine("Teste Calcular_SalarioAcimaFaixa275Test: Passou");
            }
            else
            {
                Console.WriteLine("Teste Calcular_SalarioAcimaFaixa275Test: Falhou");
            }
        }
    }
}
