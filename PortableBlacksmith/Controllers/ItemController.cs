﻿using MediatR;
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
        public async Task<IActionResult> GetItems()
        {
            var result = await _mediator.Send(new GetAllItemsQuery());

            return new OkObjectResult(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(IEnumerable<ItemDto>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetItemById(int id)
        {
            var result = await _mediator.Send(new GetItemByIdQuery() { Id = id});

            return new OkObjectResult(result);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(IEnumerable<ItemDto>), 201)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateItem([FromBody] CreateItemCommand command)
        {
            var result = await _mediator.Send(command);

            return new OkObjectResult(result);
        }
    }
}
