using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDetailDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<ResultOrderingDetailDto, OrderDetail>().ReverseMap();
            CreateMap<CreateOrderingDetailDto, OrderDetail>().ReverseMap();
            CreateMap<UpdateOrderingDetailDto, OrderDetail>().ReverseMap();
        }
    }
}
