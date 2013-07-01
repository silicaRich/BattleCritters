using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BattleCrittersMetro
{
    public abstract class DrawableObject
    {
        public object Tag;
        public Vector2 position;
        public Rectangle area;
        public Texture2D texture;
        public Color color;
        public delegate void ClickEventHandler(object source, ClickEventArgs e);
        public delegate void UpdateEventHandler(object source, UpdateEventArgs e);
        public virtual void OnClick(Vector2 clickPoint)
        {
        }
        public virtual void OnUnClick(Vector2 clickPoint)
        {
        }
        public virtual void Draw(GameTime gameTime, SpriteBatch sb)
        {
            if(this.area == null)
                this.area = new Rectangle(
                (int)position.X, 
                (int)position.Y,
                (int)position.X + texture.Width, 
                (int)position.Y + texture.Height);

            sb.Draw(texture, area, color);
        }

        public virtual void Update(Game game, GameTime gameTime)
        {
        }
        //This is a class which describes the event to the class that recieves it.
        //An EventArgs class must always derive from System.EventArgs.
        public class ClickEventArgs : EventArgs
        {
            public Vector2 clickPoint;
            public ClickEventArgs(Vector2 clickPoint)
            {
                this.clickPoint = clickPoint;
            }
        }

        public class UpdateEventArgs : EventArgs
        {
            public UpdateEventArgs()
            {
            }
        }


    }
}
