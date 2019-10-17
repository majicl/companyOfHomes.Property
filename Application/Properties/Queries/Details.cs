using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using AutoMapper;
using Domain.Properties;
using MediatR;

namespace Application.Properties
{
    public class Details
    {
        public class Query : IRequest<PropertyDto>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, PropertyDto>
        {
            private readonly IPropertyRepository _propertyRepository;
            private readonly IMapper _mapper;
            public Handler(IPropertyRepository propertyRepository, IMapper mapper)
            {
                _propertyRepository = propertyRepository;
                _mapper = mapper;
            }

            public async Task<PropertyDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var property = await _propertyRepository.GetByIdAsync(request.Id);

                if (property == null)
                    throw new RestException(HttpStatusCode.NotFound, new { Activity = "Not found" });

                return new PropertyDto
                {
                    Title = property.Title
                };
        }
        }
    }
}