using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Worthix.API.Application.Utils;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.DTOs
{
    public class AutorDTO
    {
        public long Id { get; set; }
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
