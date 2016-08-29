using FluentNHibernate.Mapping;
using SkateOne.Domain;

namespace SkateOne.Data.Nh.Map
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