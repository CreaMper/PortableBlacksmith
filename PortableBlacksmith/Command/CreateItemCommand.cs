using MediatR;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class CreateItemCommand : IRequest<ItemDto>
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
