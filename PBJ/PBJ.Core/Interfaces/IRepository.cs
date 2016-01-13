using System.Collections.Generic;

namespace PBJ.Core.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T b);
        void Edit(T b);
        void Delete(string Id);
        IEnumerable<T> FindAll();
        T FindById(string Id);
    }
}
