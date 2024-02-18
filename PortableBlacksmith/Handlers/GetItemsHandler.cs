﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.Common.Models;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class GetItemsHandler : IRequestHandler<GetAllItemsQuery, ActionResult<IEnumerable<ItemDto>>>
    {
        private readonly IFactory _factory;
        private readonly IItemConverter _converter;

        public GetItemsHandler(IFactory factory, IItemConverter converter) 
        {
            _factory = factory;
            _converter = converter;
        }

        public async Task<ActionResult<IEnumerable<ItemDto>>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var itemList = new List<ItemDto>();

            var items = await _factory.ItemRepository.GetAllItemsAsync();
            foreach (var item in items)
            {
                var modifiers = await _factory.ItemHasModifiersRepository.GetItemModifiersAsync(item.Id);
                itemList.Add(_converter.Convert(item, modifiers));
            }

            return itemList;
        }
    }
}
