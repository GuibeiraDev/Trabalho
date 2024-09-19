using Trabalho;


namespace Trabalho.Tests
{
    [TestClass]
    public class TorresDeHanoiTests
    {
        [TestMethod]
        public void TestarTorresDeHanoiComDiscosVariados()
        {
            // Preparar
            TorresDeHanoi.ResetMovimentos();
            int numeroDeDiscos = 4; // testar numeros de discos
            var esperado = (int)Math.Pow(2, numeroDeDiscos) - 1; // � o numero exato de movimentos

            // Captura da sa�da do console
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // A��o
                TorresDeHanoi.Resolver(numeroDeDiscos, 'A', 'C', 'B');

                // Obter o resultado
                var movimentosRealizados = TorresDeHanoi.ObterMovimentos();

                // Verificar
                Assert.AreEqual(esperado, movimentosRealizados, $"O n�mero de movimentos esperado para {numeroDeDiscos} discos � {esperado}, mas foi {movimentosRealizados}.");
            }
        }
    }
}