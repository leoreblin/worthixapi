using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.Mappers
{
    public class MapperLivro : IMapperLivro
    {
        public Livro MapperDtoToEntity(LivroDTO livroDTO)
        {
            Livro livro = new Livro()
            {
                LivroId = livroDTO.Id,
                AutorId = livroDTO.AutorId,
                Categoria = livroDTO.Categoria,
                DataLancamento = livroDTO.DataLancamento,
                ISBN = livroDTO.ISBN,
                Titulo = livroDTO.Titulo
            };

            return livro;
        }

        public LivroDTO MapperEntityToDto(Livro livro)
        {
            LivroDTO livroDTO = new LivroDTO()
            {
                Id = livro.LivroId,
                Titulo = livro.Titulo,
                ISBN = livro.ISBN,
                DataLancamento = livro.DataLancamento,
                Categoria = livro.Categoria,
                AutorId = livro.AutorId
            };

            return livroDTO;
        }

        public IEnumerable<LivroDTO> MapperListLivroDto(IEnumerable<Livro> livros)
        {
            var dto = livros.Select(
                l => new LivroDTO
                {
                    Id = l.LivroId,
                    AutorId = l.AutorId,
                    ISBN = l.ISBN,
                    Categoria = l.Categoria,
                    Titulo = l.Titulo,
                    DataLancamento = l.DataLancamento
                }
            );

            return dto;
        }
    }
}
