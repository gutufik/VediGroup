using Microsoft.AspNetCore.Components;
using VediGroup.Services;

namespace VediGroup.Pages.Account
{
    public class LoginModel: ComponentBase
    {
        [Inject] ILocalStorageService LocalStorageService { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        public LoginModel()
        {
            ViewModel = new LoginViewModel();
        }
        public LoginViewModel ViewModel { get; set; }
        protected async Task LoginAsync()
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

    public class SecurityToken
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
