using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Controllers
{
    [Route("v1/[controller]")]
    [Controller]
    public class UserController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets user data for selected ID
        /// </summary>
        /// <param name="id">UserId</param>
        /// <returns>User data</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var result = await _mediator.Send(new GetUserQuery() { Id = id });

            return result;
        }

    }
}
