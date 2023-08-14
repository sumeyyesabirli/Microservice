using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Order.Presenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AdddressList()
        {
            var values = await _mediator.Send(new GetAllAddressQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AddressGetById(int id)
        {
            var valus=await _mediator.Send(new GetByIdAddressQueryRequest(id));
            return Ok(valus);   
        }
        [HttpPost]
        public async Task<IActionResult> AddressCreate(CreateAddressCommandRequest request)
        {
             await _mediator.Send(request);
            return Ok("Adres Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> AddressUpdate(UpdateAddressCommandRequest request)
        { 
            await _mediator.Send(request);
            return Ok("Adres Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> AddressDelete(int id)
        {
            await _mediator.Send(new RemoveAddressCommadRequest(id));
            return Ok("Adres Silindi");
        }
    }
}
