using Core.DataBase;
using System.ComponentModel.DataAnnotations;

namespace VediGroup.Pages.HotelsPages
{
    public class HotelViewModel
    {
        private string name;

        public HotelViewModel()
        {

            Hotel = new Hotel();
        }
        public Hotel Hotel { get; set; }

        [Required]
        public string Name { get => Hotel.Name; set => Hotel.Name = value; }

        public int CityId { get => Hotel.CityId; set { Hotel.CityId = value; } }

    }


}
