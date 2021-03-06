using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Core.Interfaces.Services;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Domain.Services
{
    public class ServiceLivro : ServiceBase<Livro>, IServiceLivro
    {
        private readonly IRepositoryLivro _repository;
        public ServiceLivro(IRepositoryLivro repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
