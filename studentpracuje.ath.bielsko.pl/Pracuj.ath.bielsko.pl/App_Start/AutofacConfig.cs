using Autofac;
using Autofac.Integration.Mvc;
using Pracuj.Services;
using studentpracuje.ath.bielsko.pl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.App_Start
{
    public static class AutofacConfig
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            var assembly = typeof(MvcApplication).Assembly;
            builder.RegisterControllers(assembly);
            builder.RegisterFilterProvider();
            builder.RegisterModule(new AutofacWebTypesModule());
            builder.RegisterType<EntityDatabaseContext>().As<DbContext>().InstancePerDependency();
            builder.RegisterGeneric(typeof(RepositoryService<>)).As(typeof(IRepositoryService<>))
                .InstancePerRequest();
            builder.RegisterType<PasswordEncryptionService>().As<IPasswordEncryptionService>().InstancePerDependency();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); 
        }
    }
}