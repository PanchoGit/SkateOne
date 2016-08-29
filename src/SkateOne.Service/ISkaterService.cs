using System.Collections.Generic;
using SkateOne.Domain;

namespace SkateOne.Service
{
    public interface ISkaterService
    {
        IEnumerable<Skater> GetAll();
    }
}
