using Autofac;
using Huanlv.Passport.Domain.AggregatesModel.UserAggregate;
using Huanlv.Passport.Domain.CommandHandlers;
using Huanlv.Passport.Infrastructure.Repositories;
using Surging.Core.CPlatform.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Huanlv.Passport.ServerHost.Infrastructure.AutofacModules
{
    public class ApplicationModule
        : Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            //builder.Register(c => new OrderQueries(QueriesConnectionString))
            //    .As<IOrderQueries>()
            //    .InstancePerLifetimeScope();

            builder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(UserCommandHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
