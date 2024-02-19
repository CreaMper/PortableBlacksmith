using Microsoft.AspNetCore.Components;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.Blazor.Pages
{
    public partial class MainGameComponent
    {
        List<ItemDto> Items;
        protected override async Task OnInitializedAsync()
        {
            using (RESTService)
            {
                var response = await RESTService.GetAsync<List<ItemDto>>("/v1/item/get-alls");
                if (!response.IsSuccess)
                    ResponseService.React(response);

                Items = response.Result;
            }
        }
    }
}
