using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
namespace BattleCrittersMetro

{
    public class GameScreen : Screen
    {
        public Trainer trainer;
        //please collapse this constructor, it has reuseable code in it. Refer to the Game Screen Initalized Method
        public GameScreen(Game1 game) : base()
        {
            GameScreenInitialized(game);
            #region screen movement, obsolete.

            //DrawableButton moveCamTop = new DrawableButton();
            //moveCamTop.baseTex =gamePage.contentManager.Load<Texture2D>("moveCamWidth");
            //moveCamTop.clickedTex = moveCamTop.baseTex;
            //moveCamTop.drawTex = moveCamTop.baseTex;

            //moveCamTop.baseColor = new Color(255, 255, 255, 128);
            //moveCamTop.clickedColor = new Color(255, 255, 255, 200);
            //moveCamTop.drawColor = moveCamTop.baseColor;

            //moveCamTop.area = new Rectangle(0, 0, moveCamTop.baseTex.Width, moveCamTop.baseTex.Height);
            //moveCamTop.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    fc.Rotate(0f, MathHelper.PiOver2);
            //};

            //screenObjs.Add("moveCamTop", moveCamTop);

            //DrawableButton moveCamBottom = new DrawableButton();
            //moveCamBottom.baseTex =gamePage.contentManager.Load<Texture2D>("moveCamWidth");
            //moveCamBottom.clickedTex = moveCamBottom.baseTex;
            //moveCamBottom.drawTex = moveCamBottom.baseTex;

            //moveCamBottom.baseColor = new Color(255, 255, 255, 128);
            //moveCamBottom.clickedColor = new Color(255, 255, 255, 200);
            //moveCamBottom.drawColor = moveCamBottom.baseColor;

            //moveCamBottom.area = new Rectangle(0, 340, moveCamBottom.baseTex.Width, moveCamBottom.baseTex.Height);
            //screenObjs.Add("moveCamBottom", moveCamBottom);

            //moveCamBottom.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    fc.Rotate(0f, MathHelper.PiOver2 * -1f);
            //};

            //DrawableButton moveCamLeft = new DrawableButton();
            //moveCamLeft.baseTex =gamePage.contentManager.Load<Texture2D>("moveCamHeight");
            //moveCamLeft.clickedTex = moveCamLeft.baseTex;
            //moveCamLeft.drawTex = moveCamLeft.baseTex;

            //moveCamLeft.baseColor = new Color(255, 255, 255, 128);
            //moveCamLeft.clickedColor = new Color(255, 255, 255, 200);
            //moveCamLeft.drawColor = moveCamLeft.baseColor;

            //moveCamLeft.area = new Rectangle(0, 40, moveCamLeft.baseTex.Width, moveCamLeft.baseTex.Height);
            //screenObjs.Add("moveCamLeft", moveCamLeft);

            //moveCamLeft.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    fc.Rotate(MathHelper.PiOver2, 0f);
            //};
            //DrawableButton moveCamRight = new DrawableButton();
            //moveCamRight.baseTex =gamePage.contentManager.Load<Texture2D>("moveCamHeight");
            //moveCamRight.clickedTex = moveCamRight.baseTex;
            //moveCamRight.drawTex = moveCamRight.baseTex;

            //moveCamRight.baseColor = new Color(255, 255, 255, 128);
            //moveCamRight.clickedColor = new Color(255, 255, 255, 200);
            //moveCamRight.drawColor = moveCamRight.baseColor;

            //moveCamRight.area = new Rectangle(700, 40, moveCamRight.baseTex.Width, moveCamRight.baseTex.Height);
            //screenObjs.Add("moveCamRight", moveCamRight);
            //moveCamRight.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    fc.Rotate(MathHelper.PiOver2 * -1f, 0f);
            //};
            //DrawableButton hitArea = new DrawableButton();
            //hitArea.baseTex =gamePage.contentManager.Load<Texture2D>("hitArea");
            //hitArea.clickedTex = hitArea.baseTex;
            //hitArea.drawTex = hitArea.baseTex;

            //hitArea.baseColor = new Color(255, 255, 255, 128);
            //hitArea.clickedColor = new Color(255, 255, 255, 200);
            //hitArea.drawColor = hitArea.baseColor;

            //hitArea.area = new Rectangle(100, 40, hitArea.baseTex.Width, hitArea.baseTex.Height);

            //hitArea.Click += (s, e2) =>
            //{
            //};

            //screenObjs.Add("hitArea", hitArea);
            #endregion screen movement, obsolete.

            //224,384
            //increase joystick size
            //add in a reload button
            //


            //DrawableImage crossHair = new DrawableImage();
            //crossHair.texture = gamePage.contentManager.Load<Texture2D>("crossHair");
            //crossHair.color = new Color(255, 255, 255, 128);
            //crossHair.area = new Rectangle(384, 224, crossHair.texture.Width, crossHair.texture.Height);
            //screenObjs.Add("crossHair", crossHair);

            //DrawableButton menuButton = new DrawableButton();
            //menuButton.baseTex =gamePage.contentManager.Load<Texture2D>("MenuButton");
            //menuButton.clickedTex = menuButton.baseTex;
            //menuButton.drawTex = menuButton.baseTex;

            //menuButton.baseColor = new Color(255, 255, 255, 128);
            //menuButton.clickedColor = new Color(255, 255, 255, 200);
            //menuButton.drawColor = menuButton.baseColor;

            //menuButton.area = new Rectangle(336, 403, menuButton.baseTex.Width, menuButton.baseTex.Height);

            //menuButton.UnClick += (s, e2) =>
            //{
            //    if (gamePage.pauseMenuScreen == null)
            //        gamePage.pauseMenuScreen = new PauseMenuScreen(gamePage);

            //    gamePage.screens.Add(gamePage.pauseMenuScreen);
            //};

            //screenObjs.Add("menuButton", menuButton);

            //DrawableButton leftStick = new DrawableButton();
            //leftStick.baseTex =gamePage.contentManager.Load<Texture2D>("circleObj");
            //leftStick.clickedTex = leftStick.baseTex;
            //leftStick.drawTex = leftStick.baseTex;

            //leftStick.baseColor = new Color(255, 255, 255, 128);
            //leftStick.clickedColor = new Color(255, 255, 255, 200);
            //leftStick.drawColor = leftStick.baseColor;

            //leftStick.area = new Rectangle(2, 382, leftStick.baseTex.Width, leftStick.baseTex.Height);


            //leftStick.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    Vector2 tappedPoint = e2.clickPoint;
            //    Vector3 moveVector = new Vector3(tappedPoint.X - leftStick.area.Center.X, 0f, tappedPoint.Y - leftStick.area.Center.Y);
            //    fc.Move(moveVector);
            //};

            //screenObjs.Add("leftStick", leftStick);


            //DrawableButton rightStick = new DrawableButton();
            //rightStick.baseTex =gamePage.contentManager.Load<Texture2D>("circleObj");
            //rightStick.clickedTex = rightStick.baseTex;
            //rightStick.drawTex = rightStick.baseTex;

            //rightStick.baseColor = new Color(255, 255, 255, 128);
            //rightStick.clickedColor = new Color(255, 255, 255, 200);
            //rightStick.drawColor = rightStick.baseColor;

            //rightStick.area = new Rectangle(702, 382, rightStick.baseTex.Width, rightStick.baseTex.Height);

            //rightStick.Click += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    Vector2 tappedPoint = e2.clickPoint;
            //    Vector2 rotateVector = new Vector2(tappedPoint.X - rightStick.area.Center.X, tappedPoint.Y - rightStick.area.Center.Y);
            //    fc.Rotate(rotateVector.X * -1f, rotateVector.Y * -1f);
            //};
            //screenObjs.Add("rightStick", rightStick);


            //DrawableButton rightStickDeadZone = new DrawableButton();
            //rightStickDeadZone.baseTex =gamePage.contentManager.Load<Texture2D>("joystickDeadZone");
            //rightStickDeadZone.clickedTex = rightStickDeadZone.baseTex;
            //rightStickDeadZone.drawTex = rightStickDeadZone.baseTex;

            //rightStickDeadZone.baseColor = new Color(255, 255, 255, 128);
            //rightStickDeadZone.clickedColor = new Color(255, 255, 255, 200);
            //rightStickDeadZone.drawColor = rightStickDeadZone.baseColor;

            //rightStickDeadZone.area = new Rectangle(743, 423, rightStickDeadZone.baseTex.Width, rightStickDeadZone.baseTex.Height);

            //rightStickDeadZone.UnClick += (s, e2) =>
            //{
            //    FreeCamera fc = gamePage.camera as FreeCamera;
            //    Bullet b = new Bullet(gamePage.bullet, fc.Position, fc.rotation, new Vector3(0.1f, 0.1f, 0.1f), false, true, (float)gamePage.gameTime.TotalTime.TotalMilliseconds);
            //    gamePage.gameObjects.Add(b);
            //};
            //screenObjs.Add("rightStickDeadZone", rightStickDeadZone);

            //DrawableText health = new DrawableText();
            //health.position = new Vector2(0f, 0f);
            //screenObjs.Add("health", health);
            //health.textColor = Color.Red;

            //DrawableText ammo = new DrawableText();
            //ammo.position = new Vector2(0f, 20f);
            //screenObjs.Add("ammo", ammo);
            //ammo.textColor = Color.Blue;
        }

        public void GameScreenInitialized(Game1 game)
        {
            //when the game screen is initalized
            this.screenObjs.Add("GamePad", GetMovePad());
             

            trainer = Trainer.TrainerTest();


        }

        public DrawableButton GetMovePad()
        {
            DrawableButton movePad = new DrawableButton();
            movePad.position = new Vector2(100f, 100f);

            movePad.texture = TextureCache.gamePad;
            movePad.drawTex = movePad.texture;
            movePad.clickedTex = movePad.texture;
            movePad.drawColor = Color.Blue;
            movePad.clickedColor = Color.White;
            movePad.Click += (s, e) =>
            {
                //move the trainer
            };


            return movePad;
        }

        //please collapse this constructor, it has reuseable code in it. Refer to the GameScreenUpdated Method
        public override void Update(Game1 game, GameTime gameTime)
        {
            GameScreenUpdated(game, gameTime);
            ////update health
            //((DrawableText)screenObjs["health"]).text = "Health: " + gamePage.player.life;
            ////update ammo
            //((DrawableText)screenObjs["ammo"]).text = "Ammo: " + gamePage.player.currAmo + "/" + gamePage.player.totalAmo;

            ////
            //gamePage.camera.Update(gamePage, gameTime);
            //gamePage.player.prevPosition = gamePage.player.Position;
            //for (int i = 0; i < gamePage.gameObjects.Count; i++)
            //{
            //    gamePage.gameObjects[i].Update(gamePage, gameTime);
            //}
            ////foreach (CustomModel cm in gamePage.gameObjects)
            ////    cm.Update(gamePage, gameTime);


            ////((DrawableText)this.screenObjs["charPosition"]).text = "Bounding Sphere Center : " + gamePage.player.boundingBox.Value.Min.ToString();
            base.Update(game, gameTime);
        }

        public void GameScreenUpdated(Game1 game, GameTime gameTime)
        {
            //when the game screen is updated

        }
    }
}
