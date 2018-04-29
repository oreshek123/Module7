using System;
using System.Collections.Generic;
using System.Text;

namespace Day7Tanks.Models
{
    public class ServiceTank
    {
        private Random random = new Random();

        public void GenerateWarTeams(War war)
        {
            for (int i = 0; i < random.Next(1, 20); i++)
            {
                Tank tank = new Tank(random.Next(0,2));
                war.team.Add(tank);
            }
        }
    }
}
