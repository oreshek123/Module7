using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Tanks.Models
{
    public enum TypeOfTank {T34, Pantera }
    public class Tank
    {
        /// <summary>
        /// Боекомлект
        /// </summary>
        private int Ammunition { get; set; }
        /// <summary>
        /// Уровень брони
        /// </summary>
        private int Armor { get; set; }
        /// <summary>
        /// Уровень маневренности
        /// </summary>
        private int Maneuverability { get; set; }
        public TypeOfTank TankType { get; set; }
       
        public Tank() { }
        public Tank(int tank)
        {
            Random random = new Random();
            Ammunition = random.Next(0, 100);
            Armor = random.Next(0, 100);
            Maneuverability = random.Next(0, 100);
            if (tank == 1)
            TankType = TypeOfTank.Pantera;
            else if (tank == 0)
                TankType = TypeOfTank.T34;
        }

        public static Tank operator *(Tank tank1, Tank tank2)
        {
            Tank winner = new Tank();
            if (tank1.Ammunition > tank2.Ammunition &&
                tank1.Armor > tank2.Armor)
            {
                winner = tank1;
            }
            else if (tank1.Maneuverability > tank2.Maneuverability &&
                     tank1.Ammunition > tank2.Ammunition)
            {
                winner = tank1;
            }
            else if (tank1.Maneuverability > tank2.Maneuverability &&
                     tank1.Armor > tank2.Armor)
            {
                winner = tank1;
            }
            else winner = tank2;

            return winner;
        }

        public override string ToString()
        {
            string info = string.Format("Тип: {0} (Боекомплект : {1} Уровень брони : {2} Уровень маневренности : {3})" , 
                this.TankType.ToString(), this.Ammunition, this.Armor, this.Maneuverability);
            return info;
        }
    }
}
