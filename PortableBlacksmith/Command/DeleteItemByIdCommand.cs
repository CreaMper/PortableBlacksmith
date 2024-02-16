using MediatR;
using PortableBlacksmith.WebAPI.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class DeleteItemByIdCommand : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
