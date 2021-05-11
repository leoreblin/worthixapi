using System;
using System.Collections.Generic;

namespace Worthix.API.Domain.Entities
{
    public class Autor : Base
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Cpf { get; set; }

        public List<Livro> Livros { get; set; }

    }
}
