using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.DTOs
{
    public class LivroDTO
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Categoria { get; set; }
        public DateTime DataLancamento { get; set; }
        public Autor Autor { get; set; }
    }
}
