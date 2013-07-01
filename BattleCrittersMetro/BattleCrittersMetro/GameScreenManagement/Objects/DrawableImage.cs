
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace BattleCrittersMetro
{
    public class DrawableImage : DrawableObject
    {

        public DrawableImage()
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
