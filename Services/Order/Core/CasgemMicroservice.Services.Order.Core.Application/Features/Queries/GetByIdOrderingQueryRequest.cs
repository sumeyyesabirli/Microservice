using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetByIdOrderingQueryRequest:IRequest<ResultOrderingDto>
    {
        public GetByIdOrderingQueryRequest(int id)
        {
            Id = id;
        }

        public  int Id { get; set; }
    }
}
