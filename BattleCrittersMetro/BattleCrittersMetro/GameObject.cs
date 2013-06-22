using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCrittersMetro
{
    public abstract class GameObject
    {
        public Vector2 position;
        public Texture2D texture;
        public Color color;

        public GameObject()
        {

        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height), color);
        }


        public virtual void Update(GameTime gameTime)
        {

        }


    }
}
