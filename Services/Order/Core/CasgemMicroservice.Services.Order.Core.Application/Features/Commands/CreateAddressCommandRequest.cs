using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class CreateAddressCommandRequest:IRequest
    {
        public string UserID { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
