using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class ContaCorrente
{
    //Propriedades
    public string CPF { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }
    public double Saldo { get; set; }

    //Atributos
    private int opcao;
    private string opcaoEscolhida;
    private string transferencia;
    private string receber;

    //Métodos
    public int ExibirOpcoes()
    {
        Console.WriteLine($"Bem vindo {Nome} a sua conta corrente");
        Console.WriteLine("\nO que deseja fazer: ");

        Console.WriteLine("\n1 - Consultar Saldo");
        Console.WriteLine("2 - Fazer Transferência");
        Console.WriteLine("3 - Receber Transferência");
        Console.WriteLine("4 - Sair da conta");

        Console.Write("\nDigite uma opção: ");
        opcaoEscolhida = Console.ReadLine();
        opcao = int.Parse(opcaoEscolhida);
        return opcao;
    }

    public void ConsultarSaldo()
    {
        Console.Clear();
        Console.WriteLine($"\n\nSeu saldo é de R$ {Saldo}");
    }

    public void FazerTransferencia()
    {
        Console.Clear();
        Console.Write("Quanto deseja transferir? - ");
        transferencia = Console.ReadLine();
        double debito = double.Parse(transferencia);

        if (debito > Saldo)
        {
            Console.WriteLine("\nSaldo insuficiente na conta");
        }
        else
        {
            Saldo -= debito;
            Console.WriteLine($"\nTransferência de R$ {debito} realizada com sucesso!");
        }
        
    }

    public void ReceberTransferencia()
    {
        Console.Clear();
        Console.Write("Quanto está recebendo? -  ");
        receber = Console.ReadLine();
        double credito = double.Parse(receber);

        Saldo += credito;
        Console.WriteLine($"\nTransferência de R$ {credito} recebida com sucesso!");
    }
}


//Métodos futuros
//public void Poupar(){}