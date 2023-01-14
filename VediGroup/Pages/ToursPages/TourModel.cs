using Microsoft.AspNetCore.Components;

namespace VediGroup.Pages.ToursPages
{
    public class TourModel : ComponentBase 
    {
        public TourModel()
        {
            ViewModel= new TourViewModel();
        }

        public TourViewModel ViewModel { get; set; }

        public async Task SaveAsync()
        {

        }

    }
}
