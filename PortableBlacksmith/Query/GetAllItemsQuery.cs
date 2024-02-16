using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.WebAPI.Models;
using System.Text.Json.Serialization;

namespace PortableBlacksmith.WebAPI.Query
{
    public class GetAllItemsQuery : IRequest<IEnumerable<ItemDto>>
    {
    }
}
