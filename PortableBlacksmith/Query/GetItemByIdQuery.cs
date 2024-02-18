using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetItemByIdQuery : IRequest<ActionResult<ItemDto>>
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
