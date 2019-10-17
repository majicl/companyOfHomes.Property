//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Threading;
//using System.Threading.Tasks;
//using Application.Properties;
//using Autofac;
//using Autofac.Core;
//using Autofac.Features.Variance;
//using MediatR;
//using MediatR.Pipeline;

//namespace API.Moudles
//{
//    public class CommandValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
//    {

//        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
//        {
//            return next();
//        }
//    }
//        public class MediatorModule : Autofac.Module
//    {
//        protected override void Load(ContainerBuilder builder)
//        {
//            builder
//    .RegisterAssemblyTypes(typeof(IRequest<>).Assembly)
//    .Where(t => t.IsClosedTypeOf(typeof(IRequest<>)))
//    .AsImplementedInterfaces();

//            builder
//                .RegisterAssemblyTypes(typeof(IRequestHandler<>).Assembly)
//                .Where(t => t.IsClosedTypeOf(typeof(IRequestHandler<>)))
//                .AsImplementedInterfaces();
//        }

//        public class ScopedContravariantRegistrationSource : IRegistrationSource
//        {
//            private readonly IRegistrationSource _source = new ContravariantRegistrationSource();
//            private readonly List<Type> _types = new List<Type>();

//            public ScopedContravariantRegistrationSource(params Type[] types)
//            {
//                if (types == null)
//                    throw new ArgumentNullException(nameof(types));
//                if (!types.All(x => x.IsGenericTypeDefinition))
//                    throw new ArgumentException("Supplied types should be generic type definitions");
//                _types.AddRange(types);
//            }

//            public IEnumerable<IComponentRegistration> RegistrationsFor(
//                Service service,
//                Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
//            {
//                var components = _source.RegistrationsFor(service, registrationAccessor);
//                foreach (var c in components)
//                {
//                    var defs = c.Target.Services
//                        .OfType<TypedService>()
//                        .Select(x => x.ServiceType.GetGenericTypeDefinition());

//                    if (defs.Any(_types.Contains))
//                        yield return c;
//                }
//            }

//            public bool IsAdapterForIndividualComponents => _source.IsAdapterForIndividualComponents;
//        }
//    }
//}
