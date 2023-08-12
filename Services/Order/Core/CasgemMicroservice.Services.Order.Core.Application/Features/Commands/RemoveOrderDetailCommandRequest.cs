using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class RemoveOrderDetailCommandRequest:IRequest
    {
        public RemoveOrderDetailCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
