using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace BattleCrittersMetro
{
    public abstract class Screen
    {
        public Dictionary<string, DrawableObject> screenObjs;
        //public List<DrawableObject> screenObjs;
        public Color bgColor = new Color(0, 0, 0, 0);

        public Screen()
        {
            screenObjs = new Dictionary<string, DrawableObject>();
        }

        public virtual void Update(Game1 game, GameTime gameTime)
        {
            HandleInput();
            foreach (KeyValuePair<string, DrawableObject> kvp in screenObjs)
            {
                DrawableObject d = kvp.Value;
                d.Update(game, gameTime);
            }
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch sb)
        {
            //draw black background
            sb.Draw(TextureCache.blackBg, Vector2.Zero, bgColor);
            foreach (KeyValuePair<string, DrawableObject> s2d in screenObjs)
                s2d.Value.Draw(gameTime, sb);
        }

        private TouchCollection lastTouchCollection;

        protected virtual void HandleInput()
        {
            TouchCollection tp = TouchPanel.GetState();

            if (tp.Count <= 0)
                return;

            DrawableButton s2d1 = null;
            Vector2 s2d1Point = new Vector2(-1, -1);
            DrawableButton s2d2 = null;
            Vector2 s2d2Point = new Vector2(-1, -1);
            int index = 0;
            foreach (TouchLocation tl in tp)
            {
                foreach (KeyValuePair<string, DrawableObject> dO in screenObjs)
                {
                    if (dO.Value is DrawableButton)
                    {
                        DrawableButton s = dO.Value as DrawableButton;

                        if (tl.State == TouchLocationState.Pressed)
                        {
                            if (s.area.Contains((int)tl.Position.X, (int)tl.Position.Y))
                            {
                                switch (index)
                                {
                                    case 0:
                                        s2d1 = s;
                                        if (s2d1 != null)
                                        {
                                            s2d1.tapIndex = index;
                                            s2d1.clicked = true;
                                            s2d1Point = tp[index].Position;
                                        }
                                        break;
                                    case 1:
                                        s2d2 = s;
                                        if (s2d2 != null)
                                        {
                                            s2d2.tapIndex = index;
                                            s2d2.clicked = true;
                                            s2d2Point = tp[index].Position;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                                s.tapIndex = -1;

                        }
                        else if (tl.State == TouchLocationState.Released)
                        {
                            if (s.tapIndex == index)
                            {
                                if (s.clicked)
                                        s.OnUnClick(tp[index].Position);
                            }
                        }
                        else if (tl.State == TouchLocationState.Moved)
                        {
                            if (s.tapIndex == index)
                            {
                                if (!(s.area.Contains((int)tl.Position.X, (int)tl.Position.Y)))
                                {
                                    s.clicked = false;
                                    s.OnUnClick(tp[index].Position);
                                    s.tapIndex = -1;
                                }
                                else
                                {
                                    switch (index)
                                    {
                                        case 0:
                                            s2d1 = s;
                                            if (s2d1 != null)
                                            {
                                                s2d1.tapIndex = index;
                                                s2d1.clicked = true;
                                                s2d1Point = tp[index].Position;
                                            }
                                            break;
                                        case 1:
                                            s2d2 = s;
                                            if (s2d2 != null)
                                            {
                                                s2d2.tapIndex = index;
                                                s2d2.clicked = true;
                                                s2d2Point = tp[index].Position;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                if (s.area.Contains((int)tl.Position.X, (int)tl.Position.Y))
                                {
                                    switch (index)
                                    {
                                        case 0:
                                            s2d1 = s;
                                            if (s2d1 != null)
                                                s2d1.tapIndex = index;
                                            break;
                                        case 1:
                                            s2d2 = s;
                                            if (s2d2 != null)
                                                s2d2.tapIndex = index;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }



                        }
                    }
                }

                switch (index)
                {
                    case 0:
                        if (s2d1 != null)
                            index++;
                        break;
                    case 1:
                        if (s2d2 != null)
                            index++;
                        break;
                    default:
                        break;
                }
            }

            if (s2d1 != null)
                s2d1.OnClick(s2d1Point);
            if (s2d2 != null)
                s2d2.OnClick(s2d2Point);

            lastTouchCollection = tp;
        }

    }
}
