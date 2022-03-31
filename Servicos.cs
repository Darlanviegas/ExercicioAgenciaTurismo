public class Pacotes
{
    public DateTime DataIda { get; set; }

    public DateTime DataRetorno { get; set; }

    public double ValorDoPacote { get; set; }
    public double CafeDaManha { get; set; }

    public double Almoco { get; set; }
    public double Janta { get; set; }

    public void CapturaData()
    {
        Console.WriteLine();
    }


}
public class Passagem
{
    public double Valor { get; set; }
    public string EmpresaAerea { get; set; }
    public int Classe { get; set; }
    public int Poltrona { get; set; }
    public DateTime DataEmbarque { get; set; }
    public DateTime HoraEmbarque { get; set; }
    public void GetResumo()
    {

    }


}
public class Passeios
{
    public double Valor { get; set; }
    public string Local { get; set; }
    public DateTime Hora { get; set; }
}
public class Voo
{
    public int NumVoo { get; set; }
    public string Origem { get; set; }
    public string Destino { get; set; }
    public DateTime Hora { get; set; }
}
public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataDeNascimento { get; set; }

    public void CapturaDadosCliente()

    {
        Console.WriteLine("Digite seu nome");
        Nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF");
        CPF = Console.ReadLine();
        Console.WriteLine("Digite sua Data de Nascimento");
        DataDeNascimento = DateTime.Parse(Console.ReadLine());
    }

}
public class Venda
{
    public double QuantidadePacotesComprados { get; set; }
    public double QuantidadePassagensCompradas { get; set; }
    public double TotalCompra { get; set; }
}