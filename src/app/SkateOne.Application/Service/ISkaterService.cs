using System.Collections.Generic;
using SkateOne.Application.Model;

namespace SkateOne.Application.Service
{
    public interface ISkaterService
    {
        IEnumerable<Skater> GetAll();
    }
}
