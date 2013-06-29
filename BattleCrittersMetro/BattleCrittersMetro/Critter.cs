using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    public class Critter : GameObject
    {
        public Element[] Element;
        public int Health;
        public int Mana;
        public int Attack;
        public int Defense;
        public int Speed;
        public Attack[] Attacks;
        public Guid ID;


        public Critter()
        {

        }

        public static Critter CritterTest(){

            Critter Turtle = new Critter()
            {
                Element = "Grass",
                Health =
                Mana =
                Attack =
                Defense = 
                Speed = 
                ID = new Guid(byte[]ID);
            }

    }

}
