using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    class Attack
    {
        public string Name;
        public int Damage;
        public int ManaCost;
        public Element[] Element;

        public Attack()
        {

        }

        //public Attack attackTest(){

<<<<<<< HEAD
        //    Attack throwRock = new Attack()
        //        {
        //            Name = "Throw Rock",
        //            Damage = 5,
        //            ManaCost = 10,
        //            ElementType = element.ElementType.Rock,
        //        };
        // }
=======
            Attack throwRock = new Attack()
                {
                Name = "Throw Rock",
                Damage = 5,
                ManaCost = 10,
                Element = new Element[] { 
                    new Element(ElementType.Rock) 
                },
                };
            return throwRock;
         }
>>>>>>> df067bd35ef9a61e1bcb5401483f378736555c7d
    }
}
