using Day7Tanks.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;


namespace Day7Tanks
{
    public class War
    {
        public List<Tank> team;
        

        public War()
        {
            team = new List<Tank>();
            
        }
        
             
        public static bool operator < (War war, War war1)
        {
            if (war.team.Count < war1.team.Count)
            return true;
            else if (war.team.Count > war1.team.Count)
                return false;

            return false;
        }
        public static bool operator >(War war, War war1)
        {
            if (war.team.Count > war1.team.Count)
                return true;
            else if (war.team.Count < war1.team.Count)
                return false;

            return false;
        }

        public static bool operator ==(War war, War war1)
        {
            if (war.team.Equals(war1))
                return true;
            else if (!(war.team.Equals(war1)))
                return false;
            return false;
        }
        public static bool operator !=(War war, War war1)
        {
         if (war.team.Equals(war1))
                return false;
            else if (!(war.team.Equals(war1)))
                return true;
            return false;
        }



    }
}
