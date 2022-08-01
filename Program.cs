using ProjeoSenai.Model;

ExemploSenaiContext context = new ExemploSenaiContext();
while(true)
{
    Console.WriteLine("O que deseja fazer? 1 - Logar, 2 - Registrar ou 3 - Sair");
    string num = Console.ReadLine();
    if(num == "1")
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome de usuario");
        Console.WriteLine("Digite sua senha");
    }
    else if(num =="2")
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome");
        Console.WriteLine("Digite uma senha");
    }
    else if(num =="3")
    {
        break;
    }

}