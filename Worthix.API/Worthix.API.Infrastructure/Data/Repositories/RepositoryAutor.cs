using System;
using System.Collections.Generic;
using System.Text;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Infrastructure.Data.Repositories
{
    public class RepositoryAutor : RepositoryBase<Autor>, IRepositoryAutor
    {
        private readonly DataContext _context;
        public RepositoryAutor(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
