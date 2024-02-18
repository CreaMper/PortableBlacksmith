using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, ActionResult<ItemDto>>
    {
        private readonly IFactory _factory;
        private readonly IItemConverter _converter;

        public GetItemByIdHandler(IFactory factory, IItemConverter converter)
        {
            _factory = factory;
            _converter = converter;
        }

        public async Task<ActionResult<ItemDto>> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            var itemData = await _factory.ItemRepository.GetItemByIdAsync(request.Id);
            if (itemData == null)
                return new NotFoundObjectResult($"Item with ID {request.Id} not found!");

            var itemModifiers = await _factory.ItemHasModifiersRepository.GetItemModifiersAsync(request.Id);

            return _converter.Convert(itemData, itemModifiers);
        }
    }
}
