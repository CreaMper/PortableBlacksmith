using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;

namespace PortableBlacksmith.Blazor.Services
{
    public class ComponentServiceInjector : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IRESTService RESTService { get; set; }

        [Inject]
        protected IToastService ToastService { get; set; }

        [Inject]
        protected IResponseService ResponseService { get; set; }
    }
}
