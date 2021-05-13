using System;
using System.ComponentModel.DataAnnotations;

namespace Worthix.API.Domain.Entities
{
    public class Livro
    {
        public long LivroId { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Título deve possuir no mínimo 5 caracteres e no máximo 100.")]
        public string Titulo { get; set; }

        public DateTime DataLancamento { get; set; }

        [RegularExpression("^[A-Za-z0-9]{3}-[A-Za-z0-9]{2}-[A-Za-z0-9]{3}-[A-Za-z0-9]{4}-[A-Za-z0-9]{1}$",
            ErrorMessage = "O ISBN deve seguir o padrão XXX-XX-XXX-XXXX-X")]
        public string ISBN { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "A Categoria deve possuir no mínimo 3 caracteres e no máximo 30.")]
        public string Categoria { get; set; }

        public long AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
