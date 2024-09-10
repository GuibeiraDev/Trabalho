// See https://aka.ms/new-console-template for more information

using Trabalho;

Calculadora calc = new Calculadora();
ImpostoRenda ir = new ImpostoRenda();
TorresDeHanoi torres = new TorresDeHanoi();
ConversorMetrosParaMilimetros conversor = new ConversorMetrosParaMilimetros();
CalculadorIMC calculadorIMC = new CalculadorIMC();

int menu;
do
{
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Somar números:");
    Console.WriteLine("2) Imposto de renda:");
    Console.WriteLine("3) Torres de Hanói:");
    Console.WriteLine("4) Converter de metros para milímetros:");
    Console.WriteLine("5) Calcular IMC:");

    if (!int.TryParse(Console.ReadLine(), out menu))
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        continue;
    }

    switch (menu)
    {
        case 1:
            Console.WriteLine("Informe o primeiro número:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                break;
            }
            Console.WriteLine("Informe o segundo número:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                break;
            }
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine("A soma entre os números {0} e {1} é: {2}", num1, num2, resultado);
            break;

        case 2:
            Console.WriteLine("Informe o salário anual:");
            if (!double.TryParse(Console.ReadLine(), out double salarioAnual))
            {
                Console.WriteLine("Salário inválido. Tente novamente.");
                break;
            }
            double imposto = ir.Calcular(salarioAnual);
            Console.WriteLine("O imposto de renda sobre o salário anual de {0} é: {1}", salarioAnual, imposto);
            break;

        case 3:
            Console.WriteLine("Informe o número de discos:");
            if (!int.TryParse(Console.ReadLine(), out int numeroDeDiscos))
            {
                Console.WriteLine("Número de discos inválido. Tente novamente.");
                break;
            }
            torres.Resolver(numeroDeDiscos, 'A', 'C', 'B');
            break;

        case 4:
            Console.WriteLine("Informe o valor em metros:");
            if (!double.TryParse(Console.ReadLine(), out double metros))
            {
                Console.WriteLine("Valor em metros inválido. Tente novamente.");
                break;
            }
            double milimetros = conversor.Converter(metros);
            Console.WriteLine("{0} metros é igual a {1} milímetros", metros, milimetros);
            break;

        case 5:
            Console.WriteLine("Informe o peso (em kg):");
            if (!double.TryParse(Console.ReadLine(), out double peso))
            {
                Console.WriteLine("Peso inválido. Tente novamente.");
                break;
            }
            Console.WriteLine("Informe a altura (em metros):");
            if (!double.TryParse(Console.ReadLine(), out double altura))
            {
                Console.WriteLine("Altura inválida. Tente novamente.");
                break;
            }
            try
            {
                double imc = calculadorIMC.Calcular(peso, altura);
                string classificacao = calculadorIMC.Classificar(imc);
                Console.WriteLine("O IMC é {0} e a classificação é: {1}", imc, classificacao);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (menu != 0);