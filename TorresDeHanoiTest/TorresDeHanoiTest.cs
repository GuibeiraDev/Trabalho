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
            var esperado = (int)Math.Pow(2, numeroDeDiscos) - 1; // é o numero exato de movimentos

            // Captura da saída do console
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Ação
                TorresDeHanoi.Resolver(numeroDeDiscos, 'A', 'C', 'B');

                // Obter o resultado
                var movimentosRealizados = TorresDeHanoi.ObterMovimentos();

                // Verificar
                Assert.AreEqual(esperado, movimentosRealizados, $"O número de movimentos esperado para {numeroDeDiscos} discos é {esperado}, mas foi {movimentosRealizados}.");
            }
        }
    }
}