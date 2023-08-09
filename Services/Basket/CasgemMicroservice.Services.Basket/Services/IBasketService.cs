﻿using CasgemMicroservice.Services.Basket.Dtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userID);
        Task<Response<bool>> SaveOrUpdate(BasketDto dto);
        Task<Response<bool>> DeleteBasket(string userID);
    }
}
