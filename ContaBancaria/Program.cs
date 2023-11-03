//Instanciando classes
ContaCorrente cc = new ContaCorrente();
cc.CPF = "4";
cc.Nome = "Guilherme";
cc.Senha = "1234";
cc.Saldo = 5000.00;

MenuPrincipal menu = new MenuPrincipal();

//Incializando variáveis
string login = null;
string senha = null;
int opcaoLopping = 0;
int sair = 0;

//Criando Métodos principais
string AcessarConta()
{
    while (login != cc.CPF || senha != cc.Senha)
    {
        Console.Clear();
        Console.WriteLine("Para acessar sua conta, informe seu Login e senha");
        Console.Write("\nInfome seu login: ");
        login = Console.ReadLine();

        Console.Write("\nInforme sua senha: ");
        senha = Console.ReadLine();
        if (login.Equals(cc.CPF) && senha.Equals(cc.Senha))
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("Login ou senha inválida, tente novamente!!!");
            Thread.Sleep(1000);
        }
        
    }
    return login;
    return senha;
}

//Inciando programa
menu.Menu();
Thread.Sleep(500);
AcessarConta();

while (opcaoLopping != 4)
{
    Console.Clear();
    Thread.Sleep(500);
    opcaoLopping = cc.ExibirOpcoes();

    if (opcaoLopping > 4)
    {
        Console.Clear();
        Console.WriteLine("\nInforme uma opção válida!!!");
        Console.WriteLine("\nDigite um número de 1 a 4");
        Thread.Sleep(2000);
        Console.Clear();
    }

    switch (opcaoLopping)
    {
        case 1:
            cc.ConsultarSaldo();
            Thread.Sleep(2000);
            Console.Clear();
            break;
        case 2:
            cc.FazerTransferencia();
            Thread.Sleep(1000);
            Console.Clear();
            break;
        case 3:
            cc.ReceberTransferencia();
            Thread.Sleep(1000);
            Console.Clear();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("\n\nVoltando ao menu principal");
            Console.Clear();
            Thread.Sleep(500);
            menu.Menu();
            Console.Clear();
            Thread.Sleep(800);
            AcessarConta();
            break;
    } 
}







