using ProjeoSenai.Model;
using System.Collections.Generic;

List<string> nome = new List<string>();
List<string> sobrenomes = new List<string>();
List<string> objetos = new List<string>();
List<string> adjetivos = new List<string>();
List<string> caracteres = new List<string>();


nome.Add("Lucas");
nome.Add("Gabriel");
nome.Add("Jonatan");
nome.Add("Pedro");
nome.Add("Larissa");
nome.Add("Leticia");
nome.Add("Jessica");
nome.Add("Mauro");
nome.Add("Ederson");
nome.Add("Maria");
nome.Add("Carla");
nome.Add("Leonardo");
nome.Add("Marcio");
nome.Add("Lucas");

sobrenomes.Add("Silva");
sobrenomes.Add("Amaral");
sobrenomes.Add("Guillen");
sobrenomes.Add("Machado");
sobrenomes.Add("Junior");
sobrenomes.Add("Mazine");
sobrenomes.Add("Pedroso");
sobrenomes.Add("Trevissan");
sobrenomes.Add("Carvalho");
sobrenomes.Add("Gonçalves");

caracteres.Add("a");
caracteres.Add("b");
caracteres.Add("c");
caracteres.Add("d");
caracteres.Add("e");
caracteres.Add("f");
caracteres.Add("g");
caracteres.Add("h");
caracteres.Add("i");
caracteres.Add("j");
caracteres.Add("k");
caracteres.Add("l");
caracteres.Add("m");
caracteres.Add("n");
caracteres.Add("o");
caracteres.Add("p");
caracteres.Add("q");
caracteres.Add("r");
caracteres.Add("s");
caracteres.Add("t");
caracteres.Add("u");
caracteres.Add("v");
caracteres.Add("w");
caracteres.Add("x");
caracteres.Add("y");
caracteres.Add("z");
caracteres.Add("1");
caracteres.Add("2");
caracteres.Add("3");
caracteres.Add("4");
caracteres.Add("5");
caracteres.Add("6");
caracteres.Add("7");
caracteres.Add("8");
caracteres.Add("9");
caracteres.Add("!");
caracteres.Add("?");
caracteres.Add("@");
caracteres.Add("#");
caracteres.Add("$");
caracteres.Add("%");
caracteres.Add("&");
caracteres.Add("*");
caracteres.Add("+");
caracteres.Add("-");
caracteres.Add(".");
caracteres.Add("=");
caracteres.Add(",");

//ExemploSenaiContext context = new ExemploSenaiContext();

Usuario user = new Usuario();
Random random = new Random();

string Name = nome[random.Next(nome.Count)];
string SobreNome = sobrenomes[random.Next(sobrenomes.Count)];

user.Nome = Name + " " + SobreNome;


for(int i = 0; i < 8; i++)
{
     user.Senha += caracteres[random.Next(caracteres.Count)];  
}

//context.Add(user);
//context.SaveChanges();

Console.WriteLine(user.Nome);
Console.WriteLine(user.Senha);