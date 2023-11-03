using System.Security.Cryptography.X509Certificates;

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
        BoasVindas();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("\n1 - Entrar em uma conta");
        Console.WriteLine("\n2 - Sair do Sistema");

        Console.Write("\nDigite 1 ou 2: ");
        escolha = Console.ReadLine();
        int opcao = int.Parse(escolha);

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

