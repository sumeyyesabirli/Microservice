using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetAllOrderDetailQueryHandler : IRequestHandler<GetAllOrdeDetailQueryRequest, List<ResultOrderingDetailDto>>
    {
        private IRepository<OrderDetail> _repository;
        private IMapper _mapper;

        public GetAllOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderingDetailDto>> Handle(GetAllOrdeDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultOrderingDetailDto>>(values);
        }
    }
}
