using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class MenuPrincipal
{
   ContaCorrente cc = new ContaCorrente();
    private string escolha = null;
    
    void BoasVindas()
    {
        //O @ serve para colocar a string como eu quero que ela apareça.
        Console.WriteLine("\r\n█▀▀ █▀█ █▄░█ ▀█▀ ▄▀█   █▄▄ ▄▀█ █▄░█ █▀▀ ▄▀█ █▀█ █ ▄▀█\r\n█▄▄ █▄█ █░▀█ ░█░ █▀█   █▄█ █▀█ █░▀█ █▄▄ █▀█ █▀▄ █ █▀█");
    }

    public int Menu()
    {
        int opcao = 0;

        BoasVindas();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("\n1 - Entrar em uma conta");
        Console.WriteLine("\n2 - Sair do Sistema");
        
        try
        {
            Console.Write("\nDigite uma opção: ");
            escolha = Console.ReadLine();
            opcao = int.Parse(escolha);
            if (opcao <= 2)
            {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\nEntrando em sua conta....");
                        break;
                    case 2:
                        SairSitema();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInforme uma opção válida!!!");
                Console.WriteLine("\nDigite somente 1 ou 2");
                Thread.Sleep(2000);
                Console.Clear();
                Menu();
            }
        }
        catch (System.FormatException)
        {
            Console.Clear();
            Console.WriteLine("\nInforme uma opção válida!!!");
            Console.WriteLine("\nDigite somente 1 ou 2");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }
        return opcao;
    }

    public void SairSitema()
    {
        Console.Clear();
        Thread.Sleep(300);
        Console.WriteLine("Saindo do sistema.....");
        Environment.Exit(0);
    }
}

