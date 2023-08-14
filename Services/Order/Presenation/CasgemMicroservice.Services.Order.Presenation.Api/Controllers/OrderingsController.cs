using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Order.Presenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AddOrderingsList()
        {
            var values = await _mediator.Send(new GetAllOrderingQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderingsGetById(int id)
        {
            var valus = await _mediator.Send(new GetByIdOrderingQueryRequest(id));
            return Ok(valus);
        }
        [HttpPost]
        public async Task<IActionResult> OrderingsCreate(CreateOrderingCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Sipariş Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderingsUpdate(UpdateOrderingCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Sipariş Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderingsDelete(int id)
        {
            await _mediator.Send(new RemoveOrderingCommandRequest(id));
            return Ok("Sipariş Silindi");
        }
    }
}

