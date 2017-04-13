using System;
using System.Collections.Generic;

namespace XPShare.Domain
{
    public interface IRepository<T>
    {
        void Add(T item);

        T Get(Guid id);

        IEnumerable<T> GetAll();

        void Delete(Guid id);
    }
}
