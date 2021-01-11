using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinoArmy;

        public Herd()
        {
            dinoArmy = new List<Dinosaur>();

        }
        public void PopulateHerd()
        {
            for (int i = dinoArmy.Count; i < 4; i++)
            {
                Console.WriteLine("Choose your dinosaure to add to the herd. 1. T-Rex 2. Raptor 3. Triceratops");
                int chosenDino = int.Parse(Console.ReadLine());
                if (chosenDino == 1)
                {
                    Dinosaur trex = new Dinosaur("T-Rex", 200, 200, 50);
                    dinoArmy.Add(trex);
                }
                else if (chosenDino == 2)
                {
                    Dinosaur raptor = new Dinosaur("Raptor", 100, 300, 60);
                    dinoArmy.Add(raptor);
                }
                else if (chosenDino == 3)
                {
                    Dinosaur triceratops = new Dinosaur("Triceratops", 300, 100, 40);
                    dinoArmy.Add(triceratops);
                }
                else
                {
                    PopulateHerd();
                }
            }
            

            

            
        }
    }
}
