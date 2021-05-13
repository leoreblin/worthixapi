using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Application.Interfaces
{
    public interface IMapperPublicacao
    {
        Publicacao MapperDtoToEntity(PublicacaoDTO autorDTO);
    }
}
