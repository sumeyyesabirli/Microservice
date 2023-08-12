using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetByIdOrderingDetailQueryRequest : IRequest<ResultOrderingDetailDto>
    {
        public GetByIdOrderingDetailQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

}
