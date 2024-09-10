using Trabalho;

namespace CalculadorIMCTest
{
    [TestClass]
    public class CalculadorIMCTest
    {
        [TestMethod]
        public void CalcularIMC_ValoresValidosTest()
        {
            // Cen�rio
            double peso = 70.0;
            double altura = 1.75;
            double imcEsperado = 70.0 / (1.75 * 1.75);
            CalculadorIMC calculadorIMC = new CalculadorIMC();

            // A��o
            double imcCalculado = calculadorIMC.Calcular(peso, altura);

            // Verifica��o
            if (Math.Abs(imcCalculado - imcEsperado) < 0.01)
            {
                Console.WriteLine("Teste CalcularIMC_ValoresValidosTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste CalcularIMC_ValoresValidosTest: Falhou");
            }
        }

        [TestMethod]
        public void CalcularIMC_AlturaInvalidaTest()
        {
            // Cen�rio
            double peso = 70.0;
            double altura = 0;
            CalculadorIMC calculadorIMC = new CalculadorIMC();

            // A��o e Verifica��o
            try
            {
                calculadorIMC.Calcular(peso, altura);
                Console.WriteLine("Teste CalcularIMC_AlturaInvalidaTest: Falhou");
            }
            catch (ArgumentException ex)
            {
                if (ex.Message == "A altura deve ser maior que zero.")
                {
                    Console.WriteLine("Teste CalcularIMC_AlturaInvalidaTest: Passou");
                }
                else
                {
                    Console.WriteLine("Teste CalcularIMC_AlturaInvalidaTest: Falhou");
                }
            }
        }

        [TestMethod]
        public void ClassificarIMC_PesoNormalTest()
        {
            // Cen�rio
            double imc = 22.0;
            string classificacaoEsperada = "Peso normal";
            CalculadorIMC calculadorIMC = new CalculadorIMC();

            // A��o
            string classificacaoCalculada = calculadorIMC.Classificar(imc);

            // Verifica��o
            if (classificacaoCalculada == classificacaoEsperada)
            {
                Console.WriteLine("Teste ClassificarIMC_PesoNormalTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste ClassificarIMC_PesoNormalTest: Falhou");
            }
        }

        [TestMethod]
        public void ClassificarIMC_SobrepesoTest()
        {
            // Cen�rio
            double imc = 28.0;
            string classificacaoEsperada = "Sobrepeso";
            CalculadorIMC calculadorIMC = new CalculadorIMC();

            // A��o
            string classificacaoCalculada = calculadorIMC.Classificar(imc);

            // Verifica��o
            if (classificacaoCalculada == classificacaoEsperada)
            {
                Console.WriteLine("Teste ClassificarIMC_SobrepesoTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste ClassificarIMC_SobrepesoTest: Falhou");
            }
        }
    }
}
