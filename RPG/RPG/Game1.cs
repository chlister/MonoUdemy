using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Graphics;
using MonoGame.Extended.Tiled.Graphics;
using MonoGame.Extended;

namespace RPG
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D player_Sprite;
        Texture2D playerDown;
        Texture2D playerUp;
        Texture2D playerLeft;
        Texture2D playerRight;

        Texture2D snakeEnemy_Sprite;
        Texture2D eyeEnemy_Sprite;
        Texture2D bush_Sprite;
        Texture2D tree_Sprite;
        Texture2D heart_Sprite;
        Texture2D bullet_Sprite;

        TiledMapRenderer mapRendere;
        TiledMap myMap;

        Camera2D cam;
        Player player = new Player();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
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
            mapRendere = new TiledMapRenderer(GraphicsDevice);
            cam = new Camera2D(GraphicsDevice);
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
            player_Sprite = Content.Load<Texture2D>("Player/player");
            playerDown = Content.Load<Texture2D>("Player/playerDown");
            playerUp = Content.Load<Texture2D>("Player/playerUp");
            playerRight = Content.Load<Texture2D>("Player/playerRight");
            playerLeft = Content.Load<Texture2D>("Player/playerLeft");

            eyeEnemy_Sprite = Content.Load<Texture2D>("Enemies/eyeEnemy");
            snakeEnemy_Sprite = Content.Load<Texture2D>("Enemies/snakeEnemy");

            bush_Sprite = Content.Load<Texture2D>("Obstacles/bush");
            tree_Sprite = Content.Load<Texture2D>("Obstacles/tree");

            bullet_Sprite = Content.Load<Texture2D>("Misc/bullet");
            heart_Sprite = Content.Load<Texture2D>("Misc/heart");

            player.animations[0] = new AnimatedSprite(playerDown, 1, 4);
            player.animations[1] = new AnimatedSprite(playerUp, 1, 4);
            player.animations[2] = new AnimatedSprite(playerLeft, 1, 4);
            player.animations[3] = new AnimatedSprite(playerRight, 1, 4);

            myMap = Content.Load<TiledMap>("Misc/GameMap");

            TiledMapObject[] allEnemies = myMap.GetLayer<TiledMapObjectLayer>("enemies").Objects;
            foreach (var en in allEnemies)
            {
                string type;
                en.Properties.TryGetValue("Type", out type);
                switch (type)
                {
                    case "Snake":
                        Enemy.enemies.Add(new Snake(en.Position));
                        break;
                    case "Eye":
                        Enemy.enemies.Add(new Eye(en.Position));
                        break;
                    default:
                        Enemy.enemies.Add(new Snake(en.Position));
                        break;
                }
            }

            TiledMapObject[] allObjects = myMap.GetLayer<TiledMapObjectLayer>("obstacles").Objects;
            foreach (var en in allObjects)
            {
                string type;
                en.Properties.TryGetValue("Type", out type);
                switch (type)
                {
                    case "Tree":
                        Obstacle.obstacles.Add(new Tree(en.Position));
                        break;
                    case "Bush":
                        Obstacle.obstacles.Add(new Bush(en.Position));
                        break;
                    default:
                        Obstacle.obstacles.Add(new Tree(en.Position));
                        break;
                }
            }
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

            if (player.Health > 0)
                player.Update(gameTime);

            cam.LookAt(player.Position);

            foreach (Projectile proj in Projectile.projectiles)
            {
                proj.Update(gameTime);
                foreach (Enemy en in Enemy.enemies)
                {
                    int sum = proj.Radius + en.Radius;
                    if (Vector2.Distance(proj.Postition, en.Position) < sum)
                    {
                        proj.Collided = true;
                        en.Health--;
                    }
                }
                if (Obstacle.DidCollide(proj.Postition, proj.Radius))
                {
                    proj.Collided = true;
                }
            }
            foreach (Enemy en in Enemy.enemies)
            {
                en.Update(gameTime, player.Position);

                int sum = player.Radius + en.Radius;
                if (Vector2.Distance(player.Position, en.Position) < sum && player.HealthTimer <= 0)
                {
                    player.Health--;
                    player.HealthTimer = 1.5F;
                }
            }
            Projectile.projectiles.RemoveAll(p => p.Collided);
            Enemy.enemies.RemoveAll(e => e.Health <= 0);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.ForestGreen);
            mapRendere.Draw(myMap,cam.GetViewMatrix());
            // TODO: Add your drawing code here

            spriteBatch.Begin(transformMatrix: cam.GetViewMatrix());

             if (player.Health > 0)
                player.anim.Draw(spriteBatch, new Vector2(player.Position.X - 48, player.Position.Y - 48));

            foreach (Projectile proj in Projectile.projectiles)
            {
                spriteBatch.Draw(bullet_Sprite, new Vector2(proj.Postition.X - proj.Radius, proj.Postition.Y - proj.Radius), Color.White);
            }
            // Obstacle draws 
            foreach (Obstacle obs in Obstacle.obstacles)
            {
                Texture2D spriteToDraw;
                if (obs.GetType() == typeof(Tree))
                {
                    spriteToDraw = tree_Sprite;
                }
                else
                {
                    spriteToDraw = bush_Sprite;
                }
                spriteBatch.Draw(spriteToDraw, obs.Position, Color.White);
            }
            // Enemy draws
            foreach (Enemy enemy in Enemy.enemies)
            {
                int rad = enemy.Radius;
                Texture2D spriteToDraw;
                if (enemy.GetType() == typeof(Snake))
                {
                    spriteToDraw = snakeEnemy_Sprite;
                }
                else
                {
                    spriteToDraw = eyeEnemy_Sprite;
                }
                spriteBatch.Draw(spriteToDraw,
                    new Vector2(enemy.Position.X - rad, enemy.Position.Y - rad),
                    Color.White);
            }
            

            spriteBatch.End();

            spriteBatch.Begin();
            for (int i = 0; i < player.Health; i++)
            {
                spriteBatch.Draw(heart_Sprite, new Vector2(3 + i * 63, 3), Color.White);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
