using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetAllOrdeDetailQueryRequest : IRequest<List<ResultOrderingDetailDto>>
    {
    }
}
