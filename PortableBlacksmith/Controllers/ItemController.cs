using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.WebAPI.Models;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Controllers
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

        [HttpGet("GetAllExistingItems")]
        [ProducesResponseType(typeof(IEnumerable<ItemDto>), 200)]
        [ProducesResponseType(500)]
        public IActionResult GetAllExistingItems()
        {
            var result = _mediator.Send(new GetAllExistingItemsQuery());

            return new OkObjectResult(result.Result);
        }
    }
}
