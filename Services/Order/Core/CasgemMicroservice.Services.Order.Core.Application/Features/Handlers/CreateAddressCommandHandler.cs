using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;
        

        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
           
        }

        public  Task Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Address
            {
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserID = request.UserID,
            };
            return  _repository.CreateAsync(values);
        }
     
    }
}
