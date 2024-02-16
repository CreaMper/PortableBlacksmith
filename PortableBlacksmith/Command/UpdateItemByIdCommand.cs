using MediatR;
using PortableBlacksmith.WebAPI.Models;

namespace PortableBlacksmith.WebAPI.Command
{
    public class UpdateItemByIdCommand : IRequest<ItemDto>
    {
        public int Id { get; set; }
    }
}
