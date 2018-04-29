using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day7Tanks;
using Day7Tanks.Models;

namespace Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceTank serviceTank = new ServiceTank();
            War war1 = new War();
            War war2 = new War();
            serviceTank.GenerateWarTeams(war1);
            serviceTank.GenerateWarTeams(war2);

            Console.WriteLine(war1>war2);
            Console.WriteLine(war1==war2);
            Console.ReadLine();
        }
    }
}
