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
       // public Attack[] Attacks;
        public Guid ID;


        public Critter()
        {

        }

        public static Critter CritterTest()
        {

            Critter Turtle = new Critter()
            {
                Element = new Element[] { 
                    new Element(ElementType.Grass) 
                },
                Health = 100,
                Mana = 20,
                Attack = 5,
                Defense = 20,
                Speed = 5,
                ID = Guid.NewGuid()//new Guid(byte[]ID);
            };
            return Turtle;
        }
    }

}
