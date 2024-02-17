using Blazored.Toast.Services;
using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.Blazor.Services
{
    public class ResponseService : IResponseService
    {
        public readonly IRESTService _restService;
        public readonly IToastService _toastService;

        public ResponseService(IRESTService restService, IToastService toastService)
        {
            _restService = restService;
            _toastService = toastService;
        }

        public void React(IRESTBaseResult result)
        {
            if (!result.IsSuccess)
                _toastService.ShowError($"Request failed! [Method: {result.Method} Code: {(int)result.StatusCode}] {result.RequestUri}");
        }
    }
}
