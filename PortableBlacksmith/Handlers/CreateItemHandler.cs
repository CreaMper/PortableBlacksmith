using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Command;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Services;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class CreateItemHandler : IRequestHandler<CreateItemCommand, ActionResult<ItemDto>>
    {
        private readonly IFactory _factory;
        private readonly IItemConverter _converter;
        private readonly IBaseModifierService _baseService;

        public CreateItemHandler(IFactory factory, IItemConverter converter, IBaseModifierService baseModifierService)
        {
            _baseService = baseModifierService;
            _factory = factory;
            _converter = converter;
        }

        public async Task<ActionResult<ItemDto>> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            if (!_baseService.BaseAllowed(request.Name))
                return new BadRequestObjectResult($"Base with the name {request.Name} is not allowed!");

            var baseModifier = _baseService.GetBaseModifierForBaseName(request.Name);
            if (baseModifier == null)
                return new BadRequestObjectResult($"Base with the name {request.Name} does not have modifiers set!");

            var item = await _factory.ItemRepository.CreateItemAsync(request.Name, request.Type, baseModifier);
            var itemModifiers = await _factory.ItemHasModifiersRepository.GetItemModifiersAsync(item.Id);

            return _converter.Convert(item, itemModifiers);
        }
    }
}
