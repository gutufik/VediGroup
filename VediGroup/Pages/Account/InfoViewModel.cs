using System.ComponentModel.DataAnnotations;
using Core.DataBase;

namespace VediGroup.Pages.Account
{
    public class InfoViewModel
    {
        public User User { get; set; }
        public InfoViewModel()
        {
            User = new User();
        }

    }
}