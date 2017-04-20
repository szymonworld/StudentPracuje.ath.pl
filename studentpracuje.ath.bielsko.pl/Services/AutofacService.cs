using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracuj.Services
{
    class AutofacService
    {
        protected void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ContractExportService>().As<IContractExportService>().InstancePerRequest().PropertiesAutowired();
            // builder.RegisterType<EmailService>().As<IEmailService>().InstancePerLifetimeScope().PropertiesAutowired();

            builder.RegisterGeneric(typeof(RepositoryService<>)).As(typeof(IRepositoryService<>))
                .InstancePerRequest();
        }
    }
}
