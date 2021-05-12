using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.Interfaces
{
    public interface IMapperAutor
    {
        Autor MapperDtoToEntity(AutorDTO autorDTO);
        IEnumerable<AutorDTO> MapperListAutorDto(IEnumerable<Autor> autores);
        AutorDTO MapperEntityToDto(Autor autor);
    }
}
