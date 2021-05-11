using System;

namespace Worthix.API.Domain.Entities
{
    public class Livro : Base
    {
        public string Titulo { get; set; }

        public DateTime DataLancamento { get; set; }

        public string ISBN { get; set; }

        public string Categoria { get; set; }

        public Autor Autor { get; set; }
    }
}
