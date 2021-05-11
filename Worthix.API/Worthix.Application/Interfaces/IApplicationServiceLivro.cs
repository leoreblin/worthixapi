using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;

namespace Worthix.API.Application.Interfaces
{
    public interface IApplicationServiceLivro
    {
        void Add(LivroDTO livroDTO);
        void Update(LivroDTO livroDTO);
        void Remove(LivroDTO livroDTO);
        IEnumerable<LivroDTO> GetAll();
        LivroDTO GetById(long id);
    }
}
