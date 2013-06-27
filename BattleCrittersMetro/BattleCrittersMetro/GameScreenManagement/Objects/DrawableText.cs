
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace BattleCrittersMetro
{
    public class DrawableText : DrawableObject
    {
        public string text;
        public Color textColor;
        public Vector2 position;
        public SpriteFont font;
        public event UpdateEventHandler updateText;
        public DrawableText()
        {
        }

        public override void Draw(GameTimerEventArgs gameTime, SpriteBatch sb)
        {
            sb.DrawString(font, text, position, textColor);
        }

        public override void Update(GamePage gamePage, GameTimerEventArgs gameTime)
        {
            if (this.updateText != null)
                this.updateText(this, new UpdateEventArgs());
            //base.Update(gamePage, gameTime);
        }
    }
}
