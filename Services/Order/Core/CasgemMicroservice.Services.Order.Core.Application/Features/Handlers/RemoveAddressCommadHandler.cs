using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class RemoveAddressCommadHandler : IRequestHandler<RemoveAddressCommadRequest>
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommadHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommadRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
