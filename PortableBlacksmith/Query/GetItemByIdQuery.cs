using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetItemByIdQuery : IRequest<ItemDto>
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
