using CommandPattern.BlazorServer.Services.Mtg.DeckCards;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Pages.Mtg.DeckCards
{
    public partial class CMCDeckChartData
    {
        [Inject]
        private IDeckCardService? DeckCardService { get; set; }

        [Parameter]
        public long DeckId { get; set; }

        [Parameter]
        public EventCallback<long> DeckIdChanged { get; set; }

        private CommandPattern.Domain.Models.Entities.Mtg.CMCBarChartData CMCBarChartData { get; set; } = new("EMPTY");

        private ChartSeries ChartSeries { get; set; } = new();

        private List<ChartSeries> Series = new List<ChartSeries>();

        private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.

        protected override async Task OnParametersSetAsync()
        {
            await DetCMCData();
        }

        private async Task DetCMCData()
        {
            if (DeckCardService == null)
            {
                throw new ArgumentNullException(nameof(DeckCardService));
            }

            var Response = await DeckCardService.GetCMCDeckData(DeckId);
            CMCBarChartData = Response != null ? Response : new CommandPattern.Domain.Models.Entities.Mtg.CMCBarChartData("Empty");
            ChartSeries = new ChartSeries() { Name = CMCBarChartData.Name, Data = CMCBarChartData.Data.ToArray() };
            Series.Add(ChartSeries);
        }
    }
}
