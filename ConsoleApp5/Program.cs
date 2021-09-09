using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int people;
            int receptionHuman = 10;
            int total;
            int hours;
            int minutes;

            Console.WriteLine("Вы заходите в поликлинику и видите огромную очередь из старушек");
            Console.WriteLine("Введите сколько их");
            people = Convert.ToInt32(Console.ReadLine());

            total = people * receptionHuman;
            hours = total / 60;
            minutes = total - (hours * 60);

            Console.WriteLine("Вам нужно отстоять в очереди - " + hours + " часов " + minutes + " минут");
            Console.ReadKey();
        }
    }
}
