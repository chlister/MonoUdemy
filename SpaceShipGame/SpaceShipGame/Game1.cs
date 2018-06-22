using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SpaceShipGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D ship_Sprite;
        Texture2D astroid_Sprite;
        Texture2D space_Sprite;

        SpriteFont gameFont;
        SpriteFont timerFont;

        Ship player = new Ship();
        Controller gameController = new Controller();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ship_Sprite = Content.Load<Texture2D>("ship");
            space_Sprite = Content.Load<Texture2D>("space");
            astroid_Sprite = Content.Load<Texture2D>("asteroid");

            gameFont = Content.Load<SpriteFont>("spaceFont");
            timerFont = Content.Load<SpriteFont>("timerFont");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            player.ShipUpdate(gameTime, gameController);
            gameController.ConUpdate(gameTime);

            for (int i = 0; i < gameController.Asteroids.Count; i++)
            {
                gameController.Asteroids[i].AsteroidUpdate(gameTime);
                if (gameController.Asteroids[i].Position.X < 0 - gameController.Asteroids[i].Radius)
                {
                    gameController.Asteroids[i].offScreen = true;
                }
                int sum = gameController.Asteroids[i].Radius + 30;
                if (Vector2.Distance(gameController.Asteroids[i].Position, player.position) < sum)
                {
                    gameController.inGame = false;
                    player.position = Ship.defaultPosition;
                    i = gameController.Asteroids.Count + 1;
                    gameController.Asteroids.Clear();
                }
            }
            gameController.Asteroids.RemoveAll(ass => ass.offScreen);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(space_Sprite, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(ship_Sprite,
                new Vector2(player.position.X - 34, player.position.Y - 50),
                Color.White);

            if (!gameController.inGame)
            {
                string menuMsg = "Press enter to begin!";
                Vector2 sizeOfText = gameFont.MeasureString(menuMsg);
                spriteBatch.DrawString(gameFont, menuMsg,
                    new Vector2(640 - sizeOfText.X / 2, 200),
                    Color.White);
            }

            for (int i = 0; i < gameController.Asteroids.Count; i++)
            {
                Vector2 tempPos = gameController.Asteroids[i].Position;
                int tempRad = gameController.Asteroids[i].Radius;
                spriteBatch.Draw(astroid_Sprite,
                    new Vector2(tempPos.X - tempRad, tempPos.Y - tempRad),
                    Color.White);
            }

            spriteBatch.DrawString(timerFont, 
                "Time: " + Math.Floor(gameController.totalTime).ToString(),
                new Vector2(3,3),
                Color.White
                );

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
