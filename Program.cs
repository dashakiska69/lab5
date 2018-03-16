using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Ticket exe = new Ticket(rnd.Next(1, 2000), rnd.Next(1, 2000), "Использован");
            Ticket exe1 = new Ticket(rnd.Next(1, 2000), rnd.Next(1, 2000), "Использован");
            //exe.reWriteTicket();


            klient ex = new klient("Alexandr", "Муж", exe , 26);

            ex.reWrite();


            klient ex1 = new klient("Анна", "Муж", exe1, 18);
            ex1.reWrite();



            Console.ReadLine();
        }
    }
}
