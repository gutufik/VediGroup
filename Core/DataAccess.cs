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
    }
}
