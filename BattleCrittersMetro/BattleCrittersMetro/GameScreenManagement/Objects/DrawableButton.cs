﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace BattleCrittersMetro
{

    public class DrawableButton : DrawableObject
    {
        public Texture2D drawTex;
        public Texture2D baseTex;
        public Texture2D clickedTex;
        public Color drawColor;
        public Color baseColor;
        public Color clickedColor;
        public Rectangle area;
        public event ClickEventHandler Click;
        public event ClickEventHandler UnClick;
        public bool clicked = false;
        public int tapIndex = -1;
        public DrawableButton()
        {
        }

        public override void OnClick(Vector2 clickPoint)
        {
            drawTex = clickedTex;
            drawColor = clickedColor;
            if (this.Click != null)
                this.Click(this, new ClickEventArgs(clickPoint));
        }

        public override void OnUnClick(Vector2 clickPoint)
        {
            if (clicked == true)
            {
                if (UnClick != null)
                    UnClick(this, new ClickEventArgs(clickPoint));
                drawTex = baseTex;
                drawColor = baseColor;
                clicked = false;
            }
            drawTex = baseTex;
            drawColor = baseColor;
        }

        public override void Draw(GameTimerEventArgs gameTime, SpriteBatch sb)
        {
            sb.Draw(drawTex, area, drawColor);
        }

    }



}