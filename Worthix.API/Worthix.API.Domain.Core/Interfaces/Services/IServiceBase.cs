using System;
using System.Collections.Generic;
using System.Text;

namespace Worthix.API.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
        IEnumerable<T> GetAll();
        T GetById(long id);
    }
}
