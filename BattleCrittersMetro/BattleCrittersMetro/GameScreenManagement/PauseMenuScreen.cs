using Microsoft.Xna.Framework;
using System.Windows;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace BattleCrittersMetro
{
    public class PauseMenuScreen : Screen
    {
        //collapse method
        public PauseMenuScreen(GamePage gamePage)
            : base()
        {
              PauseMenuScreenInitalized(gamePage);
        //    this.bgColor = new Color(0, 0, 0, 100);
        //    DrawableButton resumeButton = new DrawableButton();
        //    resumeButton.baseTex = gamePage.contentManager.Load<Texture2D>("resumeButton");
        //    resumeButton.clickedTex = resumeButton.baseTex;
        //    resumeButton.drawTex = resumeButton.baseTex;

        //    resumeButton.baseColor = new Color(255, 255, 255, 128);
        //    resumeButton.clickedColor = new Color(255, 255, 255, 200);
        //    resumeButton.drawColor = resumeButton.baseColor;

        //    resumeButton.area = new Rectangle(313, 140, resumeButton.baseTex.Width, resumeButton.baseTex.Height);

        //    resumeButton.UnClick += (s, e2) =>
        //    {
        //        gamePage.screens.Remove(this);
        //    };
        //    screenObjs.Add("resumeButton", resumeButton);

        //    DrawableButton settingsButton = new DrawableButton();
        //    settingsButton.baseTex = gamePage.contentManager.Load<Texture2D>("settingsButton");
        //    settingsButton.clickedTex = settingsButton.baseTex;
        //    settingsButton.drawTex = settingsButton.baseTex;

        //    settingsButton.baseColor = new Color(255, 255, 255, 128);
        //    settingsButton.clickedColor = new Color(255, 255, 255, 200);
        //    settingsButton.drawColor = settingsButton.baseColor;

        //    settingsButton.area = new Rectangle(313, 210, settingsButton.baseTex.Width, settingsButton.baseTex.Height);

        //    settingsButton.UnClick += (s, e2) =>
        //    {
        //        gamePage.NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        //    };
        //    screenObjs.Add("settingsButton", settingsButton);


        //    DrawableButton exitButton = new DrawableButton();
        //    exitButton.baseTex = gamePage.contentManager.Load<Texture2D>("exitButton");
        //    exitButton.clickedTex = exitButton.baseTex;
        //    exitButton.drawTex = exitButton.baseTex;

        //    exitButton.baseColor = new Color(255, 255, 255, 128);
        //    exitButton.clickedColor = new Color(255, 255, 255, 200);
        //    exitButton.drawColor = exitButton.baseColor;

        //    exitButton.area = new Rectangle(313, 280, exitButton.baseTex.Width, exitButton.baseTex.Height);

        //    exitButton.UnClick += (s, e2) =>
        //    {
        //        MessageBoxResult r = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.OKCancel);
        //        if (r == MessageBoxResult.OK)
        //        {
        //            gamePage.NavigationService.GoBack();
        //        }
        //    };
        //    screenObjs.Add("exitButton", exitButton);

        //    DrawableButton DevButton = new DrawableButton();
        //    DevButton.baseTex = gamePage.contentManager.Load<Texture2D>("DevButton");
        //    DevButton.clickedTex = DevButton.baseTex;
        //    DevButton.drawTex = DevButton.baseTex;

        //    DevButton.baseColor = new Color(255, 255, 255, 1);
        //    DevButton.clickedColor = new Color(128, 128, 128, 255);
        //    DevButton.drawColor = DevButton.baseColor;

        //    DevButton.area = new Rectangle(500, 280, DevButton.baseTex.Width, DevButton.baseTex.Height);




        //    DrawableText charPosition = new DrawableText()
        //    {
        //        text = "",
        //        position = new Vector2(132f, 400f),
        //        font = gamePage.contentManager.Load<SpriteFont>("gamefont"),
        //        textColor = Color.White
        //    };
        //    charPosition.updateText += (s, e2) =>
        //        {
        //            charPosition.text = gamePage.devString;
        //        };




        //    DevButton.UnClick += (s, e2) =>
        //    {
        //        if (gamePage.gameScreen.screenObjs.ContainsKey("charPosition"))
        //            gamePage.gameScreen.screenObjs.Remove("charPosition");
        //        else
        //            gamePage.gameScreen.screenObjs.Add("charPosition", charPosition);
        //    };
        //    screenObjs.Add("DevButton", DevButton);
        }

        private void PauseMenuScreenInitalized(GamePage gamePage)
        {
        }

        public override void Draw(GameTime gameTime, SpriteBatch sb)
        {
            //draw black background
            sb.Draw(TextureCache.blackBg, Vector2.Zero, bgColor);
            base.Draw(gameTime, sb);
        }
    }
}
