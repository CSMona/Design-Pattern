using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player.Builder("Aziz", "Android")
                .Height(10.2)
                .Phone("0555555555")
                .Salary(100)
                .Build();
            Console.WriteLine(player.height);
        }
    }
}
