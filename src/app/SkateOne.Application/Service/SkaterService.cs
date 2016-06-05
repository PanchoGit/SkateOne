using System.Collections.Generic;
using SkateOne.Application.Data;
using SkateOne.Application.Model;

namespace SkateOne.Application.Service
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
