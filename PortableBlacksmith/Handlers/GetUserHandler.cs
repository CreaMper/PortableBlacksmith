using MediatR;
using Microsoft.AspNetCore.Mvc;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters;
using PortableBlacksmith.WebAPI.Models;
using PortableBlacksmith.WebAPI.Query;

namespace PortableBlacksmith.WebAPI.Handlers
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, ActionResult<UserDto>>
    {
        private readonly IFactory _factory;
        private readonly IUserConverter _converter;

        public GetUserHandler(IFactory factory, IUserConverter converter)
        {
            _converter = converter;
            _factory = factory;
        }

        public async Task<ActionResult<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _factory.UserRepository.GetUserByIdAsync(request.Id);
            if (user == null)
                return new NotFoundObjectResult($"User with ID: {request.Id} was not found!");

            var userEnergy = await _factory.UserEnergyRepository.GetEnergyForUserIdAsync(user.Id);
            if (userEnergy == null)
                return new NotFoundObjectResult($"User energy data is corrupted!");

            return _converter.Convert(user, userEnergy);
        }
    }
}
