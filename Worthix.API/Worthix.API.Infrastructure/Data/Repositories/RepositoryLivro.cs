using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Entities;

namespace Worthix.API.Infrastructure.Data.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        private readonly DataContext _context;
        public RepositoryLivro(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
