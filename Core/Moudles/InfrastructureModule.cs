//using System;
//using Autofac;
//using Domain.Properties;
//using Domain.SeedWork;
//using Persistence;
//using Persistence.Properties;

//namespace API.Moudles
//{
//    public class InfrastructureModule : Autofac.Module
//    {
//        private readonly string _databaseConnectionString;

//        public InfrastructureModule(string databaseConnectionString)
//        {
//            this._databaseConnectionString = databaseConnectionString;
//        }

//        protected override void Load(ContainerBuilder builder)
//        {
//            builder.RegisterType<UnitOfWork>()
//                .As<IUnitOfWork>()
//                .InstancePerLifetimeScope();

//            builder.RegisterType<PropertyRepository>()
//                .As<IPropertyRepository>()
//                .InstancePerLifetimeScope();
//        }
//    }
//}
