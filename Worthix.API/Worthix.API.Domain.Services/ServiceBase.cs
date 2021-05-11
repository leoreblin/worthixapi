using System.Collections.Generic;
using Worthix.API.Domain.Core.Interfaces.Repositories;
using Worthix.API.Domain.Core.Interfaces.Services;

namespace Worthix.API.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;
        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Add(T obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(long id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }
    }
}
