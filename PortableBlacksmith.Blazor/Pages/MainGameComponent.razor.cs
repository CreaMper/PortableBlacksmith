using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.Blazor.Pages
{
    public partial class MainGameComponent
    {
        UserDto? UserData;
        protected override async Task OnInitializedAsync()
        {
            using (RESTService)
            {
                var response = await RESTService.GetAsync<UserDto>("/v1/User/1");
                if (!response.IsSuccess)
                    ResponseService.React(response);

                UserData = response.Result;
            }
        }
    }
}
