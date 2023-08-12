using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class CreateOrderingDetailCommandRequest : IRequest
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public int OrderingID { get; set; }
    }
}
