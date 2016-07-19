using System.Collections.Generic;

namespace Common.Data.Base
{
    public interface IRepositoryBase<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
