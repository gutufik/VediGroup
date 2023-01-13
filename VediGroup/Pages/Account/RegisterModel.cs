using Microsoft.AspNetCore.Components;
using VediGroup.Services;

namespace VediGroup.Pages.Account
{
    public class RegisterModel: ComponentBase
    {
        [Inject] ILocalStorageService LocalStorageService { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        public RegisterModel() 
        {
            ViewModel = new RegisterViewModel();
        }

        public RegisterViewModel ViewModel { get; set; }

        protected async Task RegisterAsync()
        {
            var token = new SecurityToken
            {
                Username = ViewModel.Username,
                Password = ViewModel.Password,
            };

            await LocalStorageService.SetAsync(nameof(SecurityToken), token);
            NavigationManager.NavigateTo("/", true);
        }
    }
}
