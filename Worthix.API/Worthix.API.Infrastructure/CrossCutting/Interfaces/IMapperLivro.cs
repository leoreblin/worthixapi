using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperLivro
    {
        Livro MapperDtoToEntity(LivroDTO livroDTO);
        IEnumerable<LivroDTO> MapperListLivroDto(IEnumerable<Livro> livros);
        LivroDTO MapperEntityToDto(Livro livro);
    }
}
