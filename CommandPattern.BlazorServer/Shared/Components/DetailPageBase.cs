using CommandPattern.BlazorServer.Commands.Navigation;
using CommandPattern.BlazorServer.Services;
using CommandPattern.Domain.Entities;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CommandPattern.BlazorServer.Shared.Components
{
    public class DetailPageBase<T> : ComponentBase
        where T : EntityBase, new()
    {
        [Inject]
        IServiceBase<T>? Service { get; set; }

        [Inject]
        private ISnackbar? SnackbarService { get; set; }

        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        public bool success;

        public MudForm? Form;

        public async void Save(T Entity, string route)
        {
            success = false;
            await Form!.Validate();

            if (NavigationManager == null)
            {
                return;
            }

            if (!Form!.IsValid)
            {
                ShowSnackbarMessage($"Form Is Invalid, see errors", MudBlazor.Color.Error);
                return;
            }

            if (Service == null)
            {
                throw new ArgumentNullException(nameof(Service));
            }

            if (Entity.Id == 0)
            {
                Create(Entity);
            }
            else
            {
                Update(Entity);
            }

            Cancel(route);
        }

        public virtual void Create(T Entity)
        {
            try
            {
                Service!.InsertEntity(Entity);
                success = true;
                StateHasChanged();
                ShowSnackbarMessage($"Added New {Entity.Name}", MudBlazor.Color.Success);
            }
            catch
            {
                success = false;
                ShowSnackbarMessage($"Could Not Add {Entity.Name}", MudBlazor.Color.Error);
            }
        }

        private void Update(T Entity)
        {
            try
            {
                Service!.UpdateEntity(Entity);
                success = true;
                StateHasChanged();
                ShowSnackbarMessage($"Updated New {Entity.Name}", MudBlazor.Color.Success);
            }
            catch
            {
                success = false;
                ShowSnackbarMessage($"Could Not Update {Entity.Name}", MudBlazor.Color.Error);
            }
        }

        public void Cancel(string route)
        {
            var navCommand = new NavigationCommand(NavigationManager!, $"/{route}", true);
            navCommand.Execute();
        }

        public async Task<T> GetEntity(int Id)
        {
            if (Service == null)
            {
                throw new ArgumentNullException(nameof(Service));
            }

            return await Service.GetEntity(Id) ?? new T() { };
        }

        public void ShowSnackbarMessage(string Message, MudBlazor.Color Color)
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
