using FluentNHibernate.Mapping;
using SkateOne.Application.Model;

namespace SkateOne.Application.DataMap
{
    public class SkateMap : ClassMap<Skate>
    {
        public SkateMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Brand);
            Map(x => x.Stance);
        }
    }
}
