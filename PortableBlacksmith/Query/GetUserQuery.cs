using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetUserQuery : IRequest<ActionResult<UserDto>>
    {
        public int Id { get; set; }
    }
}
