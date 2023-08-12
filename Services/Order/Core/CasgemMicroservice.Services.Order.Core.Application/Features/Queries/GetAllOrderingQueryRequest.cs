using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetAllOrderingQueryRequest:IRequest<List<ResultOrderingDto>>
    {
    }
}
