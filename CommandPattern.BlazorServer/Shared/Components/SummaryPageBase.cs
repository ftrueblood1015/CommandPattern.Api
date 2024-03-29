﻿using CommandPattern.BlazorServer.Commands.Navigation;
using CommandPattern.BlazorServer.Services;
using CommandPattern.Domain.Entities;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Shared.Components
{
    public class SummaryPageBase<T> : ComponentBase
        where T : EntityBase
    {
        [Inject]
        IServiceBase<T>? Service { get; set; }

        [Inject]
        private IDialogService? DialogService { get; set; }

        [Inject]
        private ISnackbar? SnackbarService { get; set; }

        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        public List<T>? Entities { get; set; }

        public string? _searchString;

        private string State = "Message box hasn't been opened yet";

        protected override async Task OnInitializedAsync()
        {
            await GetData();
        }

        public async Task GetData()
        {
            if (Service == null)
            {
                throw new Exception($"{nameof(Service)}  is null!");
            }

            var Response = await Service.GetAllEntities();
            Entities = Response != null ? Response.ToList() : new List<T>();
            StateHasChanged();
        }

        public virtual Func<T, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.Name!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Description!.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.IsActive}".Contains(_searchString))
                return true;

            return false;
        };

        public async void OnDeleteClicked(T item)
        {
            if (DialogService == null)
            {
                throw new Exception($"{nameof(DialogService)}  is null!");
            }

            bool? result = await DialogService.ShowMessageBox(
                "Warning",
                "Deleting can not be undone!",
                yesText:"Delete!", cancelText:"Cancel"
            );

            State = result == null ? "Canceled" : "Deleted!";

            if (State != "Canceled")
            {
                await Delete(item);
            }
        }

        private async Task<bool> Delete(T Item)
        {
            if (Service == null)
            {
                throw new Exception($"{nameof(Service)} is null!");
            }

            try
            {
                var result = await Service.DeleteEntity(Item.Id);

                if (result)
                {
                    ShowSnackbarMessage($"Deleted {Item.Name}", MudBlazor.Color.Success);
                    await GetData();
                }
                else
                {
                    ShowSnackbarMessage($"Could Not Delete {Item.Name}", MudBlazor.Color.Error);
                }

                return result;
            }
            catch (Exception ex)
            {
                ShowSnackbarMessage($"Could Not Delete {Item.Name}: {ex}", MudBlazor.Color.Error);
                return false;
            }
        }

        public void Edit(T item, string route)
        {
            var navCommand = new NavigationCommand(NavigationManager!, $"/{route}/{item.Id}", false);
            navCommand.Execute();
        }

        public void Add(string route)
        {
            var navCommand = new NavigationCommand(NavigationManager!, $"/{route}", false);
            navCommand.Execute();
        }

        private void ShowSnackbarMessage(string Message, MudBlazor.Color Color)
        {
            if (SnackbarService == null)
            {
                throw new ArgumentNullException(nameof(SnackbarService));
            }

            SnackbarService.Add<MudChip>(new Dictionary<string, object>() {
                { "Text", $"{Message}" },
                { "Color", Color }
            });
        }
    }
}
