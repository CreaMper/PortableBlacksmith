using MediatR;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetAllItemsQuery : IRequest<IEnumerable<ItemDto>>
    {
    }
}
