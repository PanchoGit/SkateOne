using System;
using System.Configuration;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using NHibernate;

namespace SkateOne.Web
{
    public static class AutofacConfig
    {
        private const string ServiceAssemblyEndName = "Service";
        private const string DataAssemblyEndName = "Data";

        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(s => s.Name.EndsWith(ServiceAssemblyEndName))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(s => s.Name.EndsWith(DataAssemblyEndName))
                .AsImplementedInterfaces();

            SetAdoConfig(builder);
            //SetNhibernateConfig(builder);
        }

        private static void SetAdoConfig(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Data.Ado.Base.RepositoryBase<>))
                .AsImplementedInterfaces()
                .WithParameter(new TypedParameter(typeof(string), ConfigurationManager.ConnectionStrings["default"].ToString()))
                ;
        }

        private static void SetNhibernateConfig(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Data.Nh.Base.RepositoryBase<>))
                .AsImplementedInterfaces();
            builder.Register(c => c.Resolve<ISessionFactory>().OpenSession())
                .As<ISession>()
                .InstancePerLifetimeScope();
            builder.Register(c => NhibernateConfig.BuildSessionFactory())
                   .As<ISessionFactory>()
                   .SingleInstance();
        }
    }
}