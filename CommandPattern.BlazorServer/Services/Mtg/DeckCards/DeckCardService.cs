﻿using CommandPattern.Domain.Entities.Mtg;
using System.Text;
using System.Text.Json;

namespace CommandPattern.BlazorServer.Services.Mtg.DeckCards
{
    public class DeckCardService : ServiceBase<DeckCard>, IDeckCardService
    {
        public DeckCardService(ApiServerClient apiServerClient) : base(apiServerClient, "DeckCard")
        {
        }

        public async Task<IEnumerable<DeckCard>?> GetAllEntitiesFiltered(long id)
        {
            using var TJson = new StringContent(JsonSerializer.Serialize(""), Encoding.UTF8, "application/json");
            var url = new Uri($"{ControllerName}/filterByDeckId/{id}", UriKind.Relative);
            var response = await this.ApiServerClient.Client.PostAsync(url, TJson);

            return await response.GetData<IEnumerable<DeckCard>>();
        }
    }
}