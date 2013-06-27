using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    public enum ElementType
    {
        Fire, 
        Water, 
        Lightening,
        Wind,
        Posion,
        Ice,
        Grass
    }

    public class Element : GameObject
    {
        public ElementType elementType;   
    }

}
