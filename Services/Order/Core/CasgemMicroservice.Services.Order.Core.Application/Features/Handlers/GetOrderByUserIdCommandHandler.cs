﻿using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using MediatR.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetOrderByUserIdCommandHandler : IRequestHandler<GetOrderByUserIdQueryRequest, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderByUserIdCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderingDto>> Handle(GetOrderByUserIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetOrderesById(x => x.UserID == request.Id);
            return _mapper.Map<List<ResultOrderingDto>>(value);
        }
    }
}
