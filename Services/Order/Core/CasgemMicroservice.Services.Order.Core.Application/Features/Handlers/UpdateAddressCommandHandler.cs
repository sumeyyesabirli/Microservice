using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AddressID);
            values.City= request.City;
            values.District= request.District;
            values.UserID= request.UserID;
            values.Detail= request.Detail;
            await _repository.UpdateAsync(values);
        }
    }
}
