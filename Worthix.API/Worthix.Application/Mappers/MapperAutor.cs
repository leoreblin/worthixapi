using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.Mappers
{
    public class MapperAutor : IMapperAutor
    {
        public Autor MapperDtoToEntity(AutorDTO autorDTO)
        {
            Autor autor = new Autor()
            {
                AutorId = autorDTO.Id,
                Nome = autorDTO.Nome,
                Cpf = autorDTO.Cpf,
                DataNascimento = autorDTO.DataNascimento,
                Livros = autorDTO.Livros
            };

            return autor;
        }

        public AutorDTO MapperEntityToDto(Autor autor)
        {
            AutorDTO autorDTO = new AutorDTO()
            {
                Id = autor.AutorId,
                Nome = autor.Nome,
                Cpf = autor.Cpf,
                DataNascimento = autor.DataNascimento,
                Livros = autor.Livros
            };

            return autorDTO;
        }

        public IEnumerable<AutorDTO> MapperListAutorDto(IEnumerable<Autor> autores)
        {
            var dto = autores.Select(
                a => new AutorDTO
                {
                    Id = a.AutorId,
                    Nome = a.Nome,
                    Cpf = a.Cpf,
                    DataNascimento = a.DataNascimento,
                    Livros = a.Livros
                });

            return dto;
        }
    }
}
