using System.Collections.Generic;
using SkateOne.Application.Model;

namespace SkateOne.Application.Data
{
    public class SkateData : ISkateData
    {
        private readonly IRepositoryBase<Skate> repositaryBase;

        public SkateData(IRepositoryBase<Skate> repositaryBase)
        {
            this.repositaryBase = repositaryBase;
        }

        public IEnumerable<Skate> GetAll()
        {
            return repositaryBase.GetAll();
        }
    }
}
