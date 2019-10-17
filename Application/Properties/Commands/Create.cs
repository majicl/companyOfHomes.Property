using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Properties;
using MediatR;
using Persistence;

namespace Application.Properties
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Token { get; set; }
            public string Title { get; set; }
            public string Path { get; set; }
            public bool AutoGenerateTitle { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IPropertyRepository _propertyRepository;
            public Handler(IPropertyRepository propertyRepository)
            {
                _propertyRepository = propertyRepository;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var property = new Property
                {
                    Title = request.Title,
                    Token = Guid.NewGuid()
                };

                var success = await _propertyRepository.SaveAsync(property) > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}
