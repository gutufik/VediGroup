using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataBase
{
    public partial class Tourist
    {
        public override string ToString()
        {
            return  Patronymic != null? $"{LastName} {FirstName[0]}. {Patronymic[0]}.": $"{LastName} {FirstName[0]}.";
        }
    }
}
