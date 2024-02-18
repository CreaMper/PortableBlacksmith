using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class CreateItemCommand : IRequest<ActionResult<ItemDto>>
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
