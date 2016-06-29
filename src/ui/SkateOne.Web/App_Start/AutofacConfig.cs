﻿using System;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using NHibernate;
using SkateOne.Application.Data;

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
            builder.RegisterGeneric(typeof(RepositoryBase<>))
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