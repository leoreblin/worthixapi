using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.DTOs
{
    public class PublicacaoDTO
    {
        public long PublicacaoId { get; set; }

        public Autor Autor { get; set; }

        public long LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}
