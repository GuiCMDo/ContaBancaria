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

        try
        {
            Console.Write("\nDigite uma opção: ");
            opcaoEscolhida = Console.ReadLine();
            opcao = int.Parse(opcaoEscolhida);
        }
        catch (System.FormatException) 
        {
            Console.Clear();
            Console.WriteLine("\nInforme uma opção válida!!!");
            Console.WriteLine("\nDigite um número de 1 a 4");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoes();
        }
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
        double debito = 0;
        try
        {
            Console.Write("Quanto deseja transferir? - ");
            transferencia = Console.ReadLine();
            debito = double.Parse(transferencia);

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
        catch (System.FormatException)
        {
            Console.Clear();
            Console.WriteLine("\nInforme uma opção válida!!!");
            Console.WriteLine("\nDigite somente número");
            Thread.Sleep(2000);
            Console.Clear();
            FazerTransferencia();
        }
    }

    public void ReceberTransferencia()
    {
        Console.Clear();
        double credito = 0;

        try
        {
            Console.Write("Quanto está recebendo? -  ");
            receber = Console.ReadLine();
            credito = double.Parse(receber);

            Saldo += credito;
            Console.WriteLine($"\nTransferência de R$ {credito} recebida com sucesso!");
        }
        catch (System.FormatException)
        {
            Console.Clear();
            Console.WriteLine("\nInforme uma opção válida!!!");
            Console.WriteLine("\nDigite somente número");
            Thread.Sleep(2000);
            Console.Clear();
            ReceberTransferencia();
        }
        
    }
}


//Métodos futuros
//public void Poupar(){}