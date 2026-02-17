using System.Collections.Generic;

namespace OOPFundamentals.Lab4
{
    public class InMemoryRepository<T> : IRepository<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
