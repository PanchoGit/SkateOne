using FluentNHibernate.Mapping;
using SkateOne.Application.Model;

namespace SkateOne.Application.DataMap
{
    public class SkaterMap : ClassMap<Skater>
    {
        public SkaterMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Brand);
            Map(x => x.Stance);
        }
    }
}
