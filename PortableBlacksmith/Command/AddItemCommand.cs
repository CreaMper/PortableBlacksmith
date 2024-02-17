using MediatR;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class AddItemCommand : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
