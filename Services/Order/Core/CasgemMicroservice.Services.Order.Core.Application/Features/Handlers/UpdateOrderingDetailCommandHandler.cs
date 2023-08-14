using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    internal class UpdateOrderingDetailCommandHandler : IRequestHandler<UpdateOrderingDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderingDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderingDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.OrderDetailID);
            values.ProductId = request.ProductID;
            values.ProductName = request.ProductName;
            values.ProductPrice = request.ProductPrice;
            values.ProductAmount = request.ProductAmount;
            values.OrderingID = request.OrderingID;

            await _repository.UpdateAsync(values);
        }
    }

}
