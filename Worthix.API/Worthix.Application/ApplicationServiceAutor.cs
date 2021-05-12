using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Application.DTOs;
using Worthix.API.Application.Interfaces;
using Worthix.API.Domain.Core.Interfaces.Services;

namespace Worthix.API.Application
{
    public class ApplicationServiceAutor : IApplicationServiceAutor
    {
        private readonly IServiceAutor _service;
        private readonly IMapperAutor _mapper;

        public ApplicationServiceAutor(IServiceAutor service, IMapperAutor mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(AutorDTO autorDTO)
        {
            var autor = _mapper.MapperDtoToEntity(autorDTO);
            _service.Add(autor);
        }

        public IEnumerable<AutorDTO> GetAll()
        {
            var autores = _service.GetAll();
            return _mapper.MapperListAutorDto(autores);
        }

        public AutorDTO GetById(long id)
        {
            var autor = _service.GetById(id);
            return _mapper.MapperEntityToDto(autor);
        }

        public void Remove(AutorDTO autorDTO)
        {
            var autor = _mapper.MapperDtoToEntity(autorDTO);
            _service.Remove(autor);
        }

        public void Update(AutorDTO autorDTO)
        {
            var autor = _mapper.MapperDtoToEntity(autorDTO);
            _service.Update(autor);
        }
    }
}
