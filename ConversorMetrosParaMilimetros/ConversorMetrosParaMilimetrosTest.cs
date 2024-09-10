using Trabalho; 

namespace ConversorMetrosParaMilimetrosTest
{
    [TestClass]
    public class ConversorMetrosParaMilimetrosTest
    {
        [TestMethod]
        public void Converter_ValorPositivoTest()
        {
            // Cen�rio
            double metros = 5.0;
            double valorEsperado = 5000.0;
            ConversorMetrosParaMilimetros conversor = new ConversorMetrosParaMilimetros();

            // A��o
            double valorConvertido = conversor.Converter(metros);

            // Verifica��o
            if (valorConvertido == valorEsperado)
            {
                Console.WriteLine("Teste Converter_ValorPositivoTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Converter_ValorPositivoTest: Falhou");
            }
        }

        [TestMethod]
        public void Converter_ValorZeroTest()
        {
            // Cen�rio
            double metros = 0.0;
            double valorEsperado = 0.0;
            ConversorMetrosParaMilimetros conversor = new ConversorMetrosParaMilimetros();

            // A��o
            double valorConvertido = conversor.Converter(metros);

            // Verifica��o
            if (valorConvertido == valorEsperado)
            {
                Console.WriteLine("Teste Converter_ValorZeroTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Converter_ValorZeroTest: Falhou");
            }
        }

        [TestMethod]
        public void Converter_ValorNegativoTest()
        {
            // Cen�rio
            double metros = -3.5;
            double valorEsperado = -3500.0;
            ConversorMetrosParaMilimetros conversor = new ConversorMetrosParaMilimetros();

            // A��o
            double valorConvertido = conversor.Converter(metros);

            // Verifica��o
            if (valorConvertido == valorEsperado)
            {
                Console.WriteLine("Teste Converter_ValorNegativoTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Converter_ValorNegativoTest: Falhou");
            }
        }
    }
}
