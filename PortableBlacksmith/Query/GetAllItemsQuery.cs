using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetAllItemsQuery : IRequest<ActionResult<IEnumerable<ItemDto>>>
    {
    }
}
