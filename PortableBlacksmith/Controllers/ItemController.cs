using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.WebAPI.Command;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.Common.Controllers
{
    [Route("v1/[controller]")]
    [Controller]
    public class ItemController : Controller
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all")]
        [ProducesResponseType(typeof(IEnumerable<ItemDto>), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems()
        {
            var result = await _mediator.Send(new GetAllItemsQuery());

            return result;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ItemDto), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ItemDto>> GetItemById(int id)
        {
            var result = await _mediator.Send(new GetItemByIdQuery() { Id = id});

            return result;
        }

        [HttpPost()]
        [ProducesResponseType(typeof(ItemDto), 201)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<ItemDto>> CreateItem([FromBody] CreateItemCommand command)
        {
            var result = await _mediator.Send(command);

            return result;
        }
    }
}
