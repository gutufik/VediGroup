using Core;
using Microsoft.AspNetCore.Components;

namespace VediGroup.Pages.ToursPages
{
    public class TourModel : ComponentBase 
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        public TourModel()
        {
            ViewModel= new TourViewModel();
        }

        public TourViewModel ViewModel { get; set; }

        public async Task SaveAsync()
        {
            DataAccess.SaveTour(ViewModel.Tour);
            NavigationManager.NavigateTo("/tours");
        }
    }
}
