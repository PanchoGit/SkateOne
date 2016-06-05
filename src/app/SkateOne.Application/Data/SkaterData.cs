using System.Collections.Generic;
using SkateOne.Application.Model;

namespace SkateOne.Application.Data
{
    public class SkaterData : ISkaterData
    {
        private readonly IRepositoryBase<Skater> repositaryBase;

        public SkaterData(IRepositoryBase<Skater> repositaryBase)
        {
            this.repositaryBase = repositaryBase;
        }

        public IEnumerable<Skater> GetAll()
        {
            return repositaryBase.GetAll();
        }
    }
}
