using System.Collections.Generic;
using Common.Data.Base;
using SkateOne.Domain;

namespace SkateOne.Data
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
