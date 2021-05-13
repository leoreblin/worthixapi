using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Worthix.API.Domain.Utils;

namespace Worthix.API.Domain.Entities
{
    public class Autor
    {
        public long AutorId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [CustomValidationCpf(ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }

        public List<Livro> Livros { get; set; }

    }
}
