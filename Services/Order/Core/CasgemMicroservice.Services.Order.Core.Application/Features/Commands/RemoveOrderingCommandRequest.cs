using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class RemoveOrderingCommandRequest : IRequest
    {
        public RemoveOrderingCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
