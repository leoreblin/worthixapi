using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;

namespace Worthix.API.Application.Interfaces
{
    public interface IApplicationServiceAutor
    {
        void Add(AutorDTO autorDTO);
        void Update(AutorDTO autorDTO);
        void Remove(AutorDTO autorDTO);
        IEnumerable<AutorDTO> GetAll();
        AutorDTO GetById(long id);
    }
}
