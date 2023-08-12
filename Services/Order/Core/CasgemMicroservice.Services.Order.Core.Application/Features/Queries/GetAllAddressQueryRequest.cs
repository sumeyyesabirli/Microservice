using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetAllAddressQueryRequest : IRequest<List<ResultAdressDto>>
    {
    }
}
