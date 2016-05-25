using System.Collections.Generic;
using SkateOne.Application.Data;
using SkateOne.Application.Model;

namespace SkateOne.Application.Service
{
    public class SkateService : ISkateService
    {
        private readonly ISkateData data;

        public SkateService(ISkateData data)
        {
            this.data = data;
        }

        public IEnumerable<Skate> GetAll()
        {
            return data.GetAll();
        }
    }
}
