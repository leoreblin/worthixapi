using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.DTOs
{
    public class AutorDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
