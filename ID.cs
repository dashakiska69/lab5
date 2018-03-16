using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ID
    {
        public int num
        {
            get; set;
        }
        //Конструктор
        public ID(int num)
        {
            this.num = num;
        }
        public void reWriteId()
        {
            Console.WriteLine("Номер: {0}\n", num)
        }
    }
}
