using System.Collections.Generic;
using SkateOne.Application.Model;

namespace SkateOne.Application.Data
{
    public interface ISkaterData
    {
        IEnumerable<Skater> GetAll();
    }
}
