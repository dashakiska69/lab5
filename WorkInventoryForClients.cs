using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    //Производный класс 2 уровня
    class WorkInventoryForClients : WorkInventory
    {
        public string dopusk_age //Допустимый возвраст
        {
            get; set;
        }

    }
}
