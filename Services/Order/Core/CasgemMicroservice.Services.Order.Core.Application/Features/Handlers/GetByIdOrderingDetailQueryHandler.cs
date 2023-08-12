using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetByIdOrderingDetailQueryHandler : IRequestHandler<GetByIdOrderingDetailQueryRequest, ResultOrderingDetailDto>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly  IMapper _mapper;

        public GetByIdOrderingDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async  Task<ResultOrderingDetailDto> Handle(GetByIdOrderingDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderingDetailDto>(values);
        }
    }
}
