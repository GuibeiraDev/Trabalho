using Trabalho;

namespace CalculadoraTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cenário
            int num1 = 10;
            int num2 = 10;
            int result;
            var calc = new Calculadora();

            //ação
            result = calc.Soma(num1, num2);

            //verificação
            Assert.AreEqual(20, result);
        }
    }
}