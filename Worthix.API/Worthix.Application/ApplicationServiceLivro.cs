using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;
using Worthix.API.Domain.Core.Interfaces.Services;

namespace Worthix.API.Application
{
    public class ApplicationServiceLivro : IApplicationServiceLivro
    {
        private readonly IServiceLivro _service;
        private readonly IMapperLivro _mapper;

        public ApplicationServiceLivro(IServiceLivro service, IMapperLivro mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(LivroDTO livroDTO)
        {
            var livro = _mapper.MapperDtoToEntity(livroDTO);
            _service.Add(livro);
        }

        public IEnumerable<LivroDTO> GetAll()
        {
            var livros = _service.GetAll();
            return _mapper.MapperListLivroDto(livros);
        }

        public LivroDTO GetById(long id)
        {
            var livro = _service.GetById(id);
            return _mapper.MapperEntityToDto(livro);
        }

        public void Remove(LivroDTO livroDTO)
        {
            var livro = _mapper.MapperDtoToEntity(livroDTO);
            _service.Remove(livro);
        }

        public void Update(LivroDTO livroDTO)
        {
            var livro = _mapper.MapperDtoToEntity(livroDTO);
            _service.Update(livro);
        }
    }
}
