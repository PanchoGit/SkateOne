using System.Collections.Generic;
using SkateOne.Data;
using SkateOne.Domain;

namespace SkateOne.Service
{
    public class SkaterService : ISkaterService
    {
        private readonly ISkaterData data;

        public SkaterService(ISkaterData data)
        {
            this.data = data;
        }

        public IEnumerable<Skater> GetAll()
        {
            return data.GetAll();
        }
    }
}
