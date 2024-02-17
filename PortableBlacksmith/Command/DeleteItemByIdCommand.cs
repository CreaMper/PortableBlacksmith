using MediatR;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class DeleteItemByIdCommand : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
