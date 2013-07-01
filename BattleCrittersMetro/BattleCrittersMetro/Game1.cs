using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace BattleCrittersMetro
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        public GraphicsDevice graphicsDevice;
        SpriteBatch _spriteBatch;
        public List<Screen> screens; //all screens
        public GameScreen gameScreen; //game screen ref in screens
        public PauseMenuScreen pauseMenuScreen; //pause screen ref in screens
        public SpriteBatch spriteBatch;

        public Game1()
        {
            Global.game = this;
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphicsDevice = _graphics.GraphicsDevice;
            spriteBatch = new SpriteBatch(graphicsDevice);
            TextureCache.Load();
            this.screens = new List<Screen>();
            this.gameScreen = new GameScreen(this);
            this.screens.Add(gameScreen);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            screens[screens.Count - 1].Update(this, gameTime); //get the last screen and update it, do not update the other screens on the stack.
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphicsDevice.SetRenderTarget(null); // set our target to screen
            graphicsDevice.Clear(Color.Red);
            // TODO: Add your drawing code here
            //graphicsDevice.DepthStencilState = DepthStencilState.Default;


            spriteBatch.GraphicsDevice.DepthStencilState = new DepthStencilState() { DepthBufferEnable = true };
            spriteBatch.Begin();

            //2d animations go here.

            foreach (Screen s in screens)
                s.Draw(gameTime, spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
