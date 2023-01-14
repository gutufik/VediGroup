using Core.DataBase;

namespace VediGroup.Pages.ToursPages
{
    public class TourViewModel
    {
        public Tour Tour { get; set; }
        public TourViewModel() 
        {
            Tour = new Tour();
        }
    }
}