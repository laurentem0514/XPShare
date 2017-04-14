using System;
using System.Collections.Generic;
using System.Linq;

namespace XPShare.Domain.Stubs
{
    public class StubRepository<T> : IRepository<T> where T : IEntity
    {
        private List<T> _items = new List<T>();

        public StubRepository()
        {
            _items.AddRange(InitialItems);
        }       

        protected virtual IEnumerable<T> InitialItems { get { return Enumerable.Empty<T>(); } }

        public void Add(T item)
        {
            if (item.Id == Guid.Empty)
            {
                item.Id = Guid.NewGuid();
            }

            _items.Add(item);
        }

        public void Delete(Guid id)
        {
            _items.RemoveAll(x => x.Id == id);
        }

        public T Get(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
