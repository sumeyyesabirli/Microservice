using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class CreateOrderingDetailCommandHandler : IRequestHandler<CreateOrderingDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderingDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public Task Handle(CreateOrderingDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new OrderDetail
            {
                ProductId = request.ProductId,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductAmount = request.ProductAmount,
                OrderingID = request.OrderingID
            };
            return _repository.CreateAsync(values);
        }
    }
}
