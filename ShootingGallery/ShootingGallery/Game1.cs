using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShootingGallery
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Varibles for the imgs
        Texture2D target_Sprite;
        Texture2D crosshairs_Sprite;
        Texture2D background_Sprite;

        // Varible for game font
        SpriteFont gameFont;

        // Define target 
        Vector2 targetPosition = new Vector2(300, 300);
        const int TARGET_RADIUS = 45;

        // Define mouse
        MouseState mState;
        bool mReleased = true;
        float mouseTargetDist;

        int score = 0;
        float timer = 10f;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //IsMouseVisible = true;
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
            target_Sprite = Content.Load<Texture2D>("target");
            crosshairs_Sprite = Content.Load<Texture2D>("crosshairs");
            background_Sprite = Content.Load<Texture2D>("sky");
            gameFont = Content.Load<SpriteFont>("File");
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

            // Adding a timer

            if (timer > 0)
                timer -= (float)gameTime.ElapsedGameTime.TotalSeconds;


            // TODO: Add your update logic here
            mState = Mouse.GetState();

            mouseTargetDist = Vector2.Distance(targetPosition, new Vector2(mState.X, mState.Y));

            if (mState.LeftButton == ButtonState.Pressed && mReleased == true)
            {
                if (mouseTargetDist < TARGET_RADIUS && timer > 0)
                {
                    score++;

                    Random rand = new Random();
                    targetPosition.X = rand.Next(TARGET_RADIUS, graphics.PreferredBackBufferWidth - TARGET_RADIUS + 1);
                    targetPosition.Y = rand.Next(TARGET_RADIUS, graphics.PreferredBackBufferHeight - TARGET_RADIUS + 1);
                }

                mReleased = false;
            }
            if (mState.LeftButton == ButtonState.Released)
            {
                mReleased = true;
            }

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

            spriteBatch.Draw(background_Sprite, new Vector2(0, 0), Color.White);
            if (timer > 0)
                spriteBatch.Draw(target_Sprite, new Vector2(targetPosition.X - TARGET_RADIUS, targetPosition.Y - TARGET_RADIUS), Color.White);

            spriteBatch.DrawString(gameFont, "Score: " + score.ToString(), new Vector2(3, 3), Color.White);
            spriteBatch.DrawString(gameFont, "Time left: " + Math.Ceiling(timer).ToString(), new Vector2(3, 40), Color.White);

            // Crosshairs
            spriteBatch.Draw(crosshairs_Sprite, new Vector2(mState.X - 25, mState.Y - 25), Color.White); // To get the img to be at the mouse we subtract the radius

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
