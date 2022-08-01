using ProjeoSenai.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Joel Santana";
usuario.Senha = "senhafraca";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();