using System;
using System.Collections.Generic;
using System.Text;

namespace Worthix.API.Domain.Entities
{
    public class Publicacao
    {
        public long PublicacaoId { get; set; }

        public Autor Autor { get; set; }

        public long LivroId { get; set; }
        public Livro Livro { get; set; }

    }
}
