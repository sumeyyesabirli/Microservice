using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetByIdOrderingQueryHandler : IRequestHandler<GetByIdOrderingQueryRequest, ResultOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultOrderingDto> Handle(GetByIdOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderingDto>(value);
        }
    }
}
