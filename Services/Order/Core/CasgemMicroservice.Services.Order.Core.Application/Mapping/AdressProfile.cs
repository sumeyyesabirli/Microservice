using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class AdressProfile : Profile
    {
        public AdressProfile()
        {
            CreateMap<ResultAdressDto, Address>().ReverseMap();
            CreateMap<CreateAdressDto, Address>().ReverseMap();
            CreateMap<UpdateAdressDto, Address>().ReverseMap();
        }
    }
}
