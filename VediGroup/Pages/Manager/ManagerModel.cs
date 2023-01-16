using Microsoft.AspNetCore.Components;
using Core.DataBase;
using Core;

namespace VediGroup.Pages.Manager
{
    public class ManagerModel : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }

        public ManagerModel()
        {
            User = new User();
        }

        public User User { get; set; }

        public async Task SaveAsync()
        {
            //DataAccess.SaveTour(ViewModel.Tour);
            //NavigationManager.NavigateTo("/tours");
        }
    }
}
