using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAdressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetByIdAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultAdressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAdressDto>(values);
        }
    }
}
