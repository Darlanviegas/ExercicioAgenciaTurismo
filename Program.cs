class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
        Console.WriteLine("Bem Vindo a agência DoDevTur !");
        Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
        Console.WriteLine();
        Console.WriteLine("Escolha sua opção");
        Console.WriteLine();
        Console.WriteLine("1- Pacotes de Viagem");
        Console.WriteLine("2- Passagens Aéreas");
        var opcao = int.Parse(Console.ReadLine());
        Venda venda = new Venda();
        if (opcao == 1)
        {
            Console.WriteLine("Quantos pacotes voce deseja comprar?");
            venda.QuantidadePacotesComprados = double.Parse(Console.ReadLine());
            Console.WriteLine("OK, vamos realizar um breve cadastro");
            Cliente cliente = new Cliente();
            cliente.CapturaDadosCliente();

        }
        else if (opcao == 2)
        {
            Console.WriteLine("Quantos passagens voce deseja comprar?");
            venda.QuantidadePassagensCompradas = double.Parse(Console.ReadLine());
            Console.WriteLine("OK, vamos realizar um breve cadastro");
            Cliente cliente = new Cliente();
            cliente.CapturaDadosCliente();
        }
        else
        {
            Console.WriteLine("Opção Inválida! Confira a opção digitada");
        }
    }
}
