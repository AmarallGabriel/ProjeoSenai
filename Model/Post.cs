using System;
using System.Collections.Generic;

namespace ProjeoSenai.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? Publicante { get; set; }
        public string Conteudo { get; set; } = null!;

        public virtual Usuario? PublicanteNavigation { get; set; }
    }
}
