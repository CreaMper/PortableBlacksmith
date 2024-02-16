﻿using MediatR;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Models;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class GetItemsHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemDto>>
    {
        private readonly IFactory _factory;
        private readonly IItemConverter _converter;

        public GetItemsHandler(IFactory factory, IItemConverter converter) 
        {
            _factory = factory;
            _converter = converter;
        }

        public async Task<IEnumerable<ItemDto>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var result = await _factory.ItemRepository.GetAllItemsAsync();
            return result.Select(x => _converter.Convert(x));
        }
    }
}