

using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using VediGroup.Services;

namespace VediGroup.Provider
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorageService;
        public CustomAuthStateProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        } 
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorageService.GetAsync<Pages.Account.SecurityToken>(nameof(Pages.Account.SecurityToken));
            var identity = new ClaimsIdentity();
            if (token != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Country, "Russia"),
                    new Claim(ClaimTypes.Role, "Administrator"),
                    new Claim(ClaimTypes.Role, "Manager"),
                };

                identity = new ClaimsIdentity(claims, "Token");
            }


            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);

            //NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}
