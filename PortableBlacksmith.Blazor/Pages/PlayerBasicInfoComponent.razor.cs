using PortableBlacksmith.Common.Models;
using static MudBlazor.Colors;

namespace PortableBlacksmith.Blazor.Pages
{
    public partial class PlayerBasicInfoComponent
    {
        public UserDto UserBasicData;
        public int EnergyBarValueLoad { get; set; }
        public int EnergyBarValue { get; set; }
        public double EnergyCountdown { get; set; }
        protected override async Task OnInitializedAsync()
        {
            UserBasicData = new UserDto()
            {
                Name = "test",
                Currency = new CurrencyDto()
                {
                    Gold = 1,
                    Mithrill = 2,
                    Steel = 11,
                    Warcraftium = 0
                },
                Energy = new EnergyDto()
                {
                    Current = 10,
                    Max = 100,
                    Min = 0,
                    Updated = DateTime.UtcNow
                }
            };
/*            using (RESTService)
            {
                var response = await RESTService.GetAsync<UserDto>("/v1/User/1");
                if (!response.IsSuccess)
                    ResponseService.React(response);

                UserBasicData = response.Result;
                EnergyBarValue = (int)((UserBasicData.Energy.Current / (double)UserBasicData.Energy.Max)*100);
            }*/
            SimulateEnergyLoad();
            StartEnergyCountdown();
        }

        private async Task SimulateEnergyLoad()
        {
            EnergyBarValueLoad = 0;
            do
            {
                EnergyBarValueLoad += 5;
                await Task.Delay(100);
                StateHasChanged();
            } while (EnergyBarValueLoad < 95);
            EnergyBarValue += 1;
            SimulateEnergyLoad();
        }

        private async Task StartEnergyCountdown()
        {
            EnergyCountdown = 2;
            while (EnergyCountdown > 0.1)
            { 
                EnergyCountdown -= 0.1;
                await Task.Delay(100);
                StateHasChanged(); 
            }
            StateHasChanged();
            StartEnergyCountdown();
        }
    }
}
