using System.Collections.Generic;
using SkateOne.Domain;

namespace SkateOne.Data
{
    public interface ISkaterData
    {
        IEnumerable<Skater> GetAll();
    }
}
