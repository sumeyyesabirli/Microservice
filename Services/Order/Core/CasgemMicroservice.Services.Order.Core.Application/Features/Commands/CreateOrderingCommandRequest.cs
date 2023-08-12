using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class CreateOrderingCommandRequest : IRequest
    {
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderingDate { get; set; }
    }
}
