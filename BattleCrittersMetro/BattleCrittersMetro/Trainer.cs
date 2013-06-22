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
        public Vector2 Postion;
        public string Location;
        public Critter[] Critters;

    }
}
