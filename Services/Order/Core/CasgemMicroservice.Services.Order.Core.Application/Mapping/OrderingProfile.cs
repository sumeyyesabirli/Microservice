using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            CreateMap<CreateOrderingDto, Ordering>().ReverseMap();
            CreateMap<ResultOrderingDto, Ordering>().ReverseMap();
            CreateMap<UpdateOrderingDto, Ordering>().ReverseMap();
        }
    }
}
