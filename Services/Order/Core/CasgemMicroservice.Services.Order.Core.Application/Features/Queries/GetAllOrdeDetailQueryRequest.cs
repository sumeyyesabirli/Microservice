using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetAllOrdeDetailQueryRequest : IRequest<List<ResultOrderingDetailDto>>
    {
    }
}
