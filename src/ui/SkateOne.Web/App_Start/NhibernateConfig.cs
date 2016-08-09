using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SkateOne.Data.Nh.Map;

namespace SkateOne.Web
{
    public class NhibernateConfig
    {
        public static ISessionFactory BuildSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2012
                    .ConnectionString(_ => _.FromConnectionStringWithKey("default"))
                    .DefaultSchema("Skate")
                    )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SkaterMap>())
                .BuildSessionFactory();
        }
    }
}