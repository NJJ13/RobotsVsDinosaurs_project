using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> roboArmy;

        public Fleet()
        {
            roboArmy = new List<Robot>();
        }
        
        public void PopulateFleet()
        {
            for (int i = roboArmy.Count; i < 4; i++)
            {
                Robot r1 = new Robot("R1", 150, 200);
                roboArmy.Add(r1);

                Robot r2 = new Robot("R2", 150, 200);
                roboArmy.Add(r2);

                Robot r3 = new Robot("R3", 150, 200);
                roboArmy.Add(r3);
            }
            
            

        }
    }
}
