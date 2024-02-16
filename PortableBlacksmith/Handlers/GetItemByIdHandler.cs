﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Models;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class GetItemByIdHandler : IRequestHandler<GetItemByIdQuery, ItemDto>
    {
        private readonly IFactory _factory;
        private readonly IItemConverter _converter;

        public GetItemByIdHandler(IFactory factory, IItemConverter converter)
        {
            _factory = factory;
            _converter = converter;
        }

        public async Task<ItemDto> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _factory.ItemRepository.GetItemByIdAsync(request.Id);
            if (result == null)
                return null;

            return _converter.Convert(result);
        }
    }
}