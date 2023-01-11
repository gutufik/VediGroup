using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataBase;

namespace Core
{
    public class DataAccess
    {
        public static List<Tour> GetTours() => VediGroupEntities.GetContext().Tours.ToList();
        public static List<Tourist> GetTourists() => VediGroupEntities.GetContext().Tourists.ToList();
        public static List<VisaAvailability> GetVisaAvailabilities() => VediGroupEntities.GetContext().VisaAvailabilities.ToList();
        public static List<Hotel> GetHotels() => VediGroupEntities.GetContext().Hotels.ToList();
        public static List<Country> GetCountries() => VediGroupEntities.GetContext().Countries.ToList();
        public static List<City> GetCities() => VediGroupEntities.GetContext().Cities.ToList();
        public static List<User> GetUsers() => VediGroupEntities.GetContext().Users.ToList();
        public static List<Role> GetRoles() => VediGroupEntities.GetContext().Roles.ToList();
    }
}
