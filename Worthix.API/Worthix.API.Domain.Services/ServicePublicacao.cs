using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Core.Interfaces.Services;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Domain.Services
{
    public class ServicePublicacao : ServiceBase<Publicacao>, IServicePublicacao
    {
        private readonly IRepositoryPublicacao _repository;
        public ServicePublicacao(IRepositoryPublicacao repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
