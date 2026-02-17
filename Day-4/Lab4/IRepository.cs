using System.Collections.Generic;

namespace OOPFundamentals.Lab4
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }
}
