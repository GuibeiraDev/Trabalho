using Trabalho;

namespace CalculadoraTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cen�rio
            int num1 = 10;
            int num2 = 10;
            int result;
            var calc = new Calculadora();

            //a��o
            result = calc.Soma(num1, num2);

            //verifica��o
            Assert.AreEqual(20, result);
        }
    }
}