using Trabalho;

namespace TrabalhoTest
{
    [TestClass]
    public class TorresDeHanoiTest
    {
        [TestMethod]
        public void Resolver_TresDiscosTest()
        {
            // Cenário
            int numeroDeDiscos = 3;
            char origem = 'A';
            char destino = 'C';
            char auxiliar = 'B';
            TorresDeHanoi torres = new TorresDeHanoi();

            // Redirecionar a saída padrão para capturar as mensagens de console
            var saidaConsole = new StringWriter();
            Console.SetOut(saidaConsole);

            // Ação
            torres.Resolver(numeroDeDiscos, origem, destino, auxiliar);

            // Verificação
            string saidaEsperada = "Mover disco 1 de A para C\r\n" +
                                   "Mover disco 2 de A para B\r\n" +
                                   "Mover disco 1 de C para B\r\n" +
                                   "Mover disco 3 de A para C\r\n" +
                                   "Mover disco 1 de B para A\r\n" +
                                   "Mover disco 2 de B para C\r\n" +
                                   "Mover disco 1 de A para C\r\n";

            if (saidaConsole.ToString() == saidaEsperada)
            {
                Console.WriteLine("Teste Resolver_TresDiscosTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Resolver_TresDiscosTest: Falhou");
                Console.WriteLine("Saída obtida:");
                Console.WriteLine(saidaConsole.ToString());
            }
        }

        [TestMethod]
        public void Resolver_UmDiscoTest()
        {
            // Cenário
            int numeroDeDiscos = 1;
            char origem = 'A';
            char destino = 'C';
            char auxiliar = 'B';
            TorresDeHanoi torres = new TorresDeHanoi();

            // Redirecionar a saída padrão para capturar as mensagens de console
            var saidaConsole = new StringWriter();
            Console.SetOut(saidaConsole);

            // Ação
            torres.Resolver(numeroDeDiscos, origem, destino, auxiliar);

            // Verificação
            string saidaEsperada = "Mover disco 1 de A para C\r\n";

            if (saidaConsole.ToString() == saidaEsperada)
            {
                Console.WriteLine("Teste Resolver_UmDiscoTest: Passou");
            }
            else
            {
                Console.WriteLine("Teste Resolver_UmDiscoTest: Falhou");
                Console.WriteLine("Saída obtida:");
                Console.WriteLine(saidaConsole.ToString());
            }
        }
    }
}
