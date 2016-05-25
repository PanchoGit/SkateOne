using System.Collections.Generic;

namespace SkateOne.Application.Data
{
    public interface IRepositoryBase<out T> where T : class 
    {
        IEnumerable<T> GetAll();
    }
}