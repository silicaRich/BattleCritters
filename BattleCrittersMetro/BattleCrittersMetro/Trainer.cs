using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    public class Trainer : GameObject
    {
        public string Name;
        public char Gender;
        public int Money;
        public Guid ID;
        public Vector2 Position;
        public string Location;
        public Critter[] Critters;

        public Trainer()
        {

        }

        public static Trainer TrainerTest(){

            Trainer trainer = new Trainer()
            {
                Name = "Bob Saget",
                Gender = 'M',
                Money =  500,
                Position = new Vector2(0f, 0f),
                Location = "Home",
            };

            trainer.Critters = new Critter [5] ;
            /*trainer.Critters[0] = ;
            trainer.Critters[1] = ;
            trainer.Critters[2] = ;*/
            return trainer;
        }

    }
}
