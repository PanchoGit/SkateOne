using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SkateOne.Application.Data;

namespace SkateOne.Web
{
    public class AppNhSessionFactoryConfig
    {
        public static ISessionFactory BuildSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(_ => _.FromConnectionStringWithKey("default")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SkaterData>())
                .BuildSessionFactory();
        }
    }
}