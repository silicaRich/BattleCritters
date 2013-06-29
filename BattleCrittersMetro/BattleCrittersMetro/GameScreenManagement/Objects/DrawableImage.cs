
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace BattleCrittersMetro
{
    public class DrawableImage : DrawableObject
    {
        public Texture2D texture;
        public Color color;
        public Rectangle area;

        public DrawableImage()
        {
        }

        public override void Draw(GameTime gameTime, SpriteBatch sb)
        {
            sb.Draw(texture, area, color);
        }

    }
}
