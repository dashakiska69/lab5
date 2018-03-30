﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Inventory //Общий класс
    {
        public string data_post //Дата поступления инвентаря
        {
            get; set;
        }
        public int srok_god //Срок годности инвентаря
        {
            get; set;
        }
        public string type //Тип инвентаря
        {
            get; set;
        }

        //Конструктор
        public Inventory(string data_post, int srok_god, string type)
        {
            this.data_post = data_post;
            this.srok_god = srok_god;
            this.type = type;
        }

        public void reWriteInventory()
        {
            Console.WriteLine("Дата поступления: {0}\nСрок годности: {1}\nТип инвентаря {2}\n", data_post, srok_god, type);
        }

       public virtual string InventoryInfo(Inventory obj)
        {
            string data_post = "Дата поступления: " + "Срок годности:" + srok_god + "Тип иневентаря" + type + "\n";
            return data_post;
        }

    }
}
