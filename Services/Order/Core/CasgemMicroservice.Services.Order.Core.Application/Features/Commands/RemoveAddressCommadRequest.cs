using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class RemoveAddressCommadRequest : IRequest
    {
        public int Id { get; set; }
        public RemoveAddressCommadRequest(int id)
        {
            Id = id;
        }
    }
}
