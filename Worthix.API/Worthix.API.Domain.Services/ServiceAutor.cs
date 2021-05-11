using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Core.Interfaces.Services;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Domain.Services
{
    public class ServiceAutor : ServiceBase<Autor>, IServiceAutor
    {
        private readonly IRepositoryAutor _repository;
        public ServiceAutor(IRepositoryAutor repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
