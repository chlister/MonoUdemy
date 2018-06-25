using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
    public class Player
    {
        private Vector2 position = new Vector2(100, 100);
        private int health = 3;
        private int speed = 200;
        private Dir direction = Dir.Down;
        private bool isMoving = false;
        private KeyboardState kStateOld = Keyboard.GetState();
        private float healthTimer = 0F;
        private int radius = 56;
        public AnimatedSprite anim;
        public AnimatedSprite[] animations = new AnimatedSprite[4];


        public int Health { get => health; set => health = value; }
        public Vector2 Position { get => position; set => position = value; } 
        public int Radius { get => radius; set => radius = value; }
        public float HealthTimer { get => healthTimer; set => healthTimer = value; }

        public void SetX(float newX)
        {
            position.X = newX;
        }

        public void SetY(float newY)
        {
            position.Y = newY;
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (healthTimer > 0)
                healthTimer -= dt;

            anim = animations[(int)direction];

            if (isMoving)
                anim.Update(gameTime);
            else
                anim.SetFrame(1);

            isMoving = false;
            if (kState.IsKeyDown(Keys.Right))
            {
                direction = Dir.Right;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                direction = Dir.Left;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                direction = Dir.Up;
                isMoving = true;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                direction = Dir.Down;
                isMoving = true;
            }

            if (isMoving)
            {
                Vector2 tempPos = position;

                switch (direction)
                {
                    case Dir.Up:
                        tempPos.Y -= speed * dt;
                        if (!Obstacle.DidCollide(tempPos, radius))
                        {
                            position.Y -= speed * dt;
                        }
                        break;
                    case Dir.Down:
                        tempPos.Y += speed * dt;
                        if (!Obstacle.DidCollide(tempPos, radius))
                        {
                            position.Y += speed * dt;
                        }
                        break;
                    case Dir.Left:
                        tempPos.X -= speed * dt;
                        if (!Obstacle.DidCollide(tempPos, radius))
                        {
                            position.X -= speed * dt;
                        }
                        break;
                    case Dir.Right:
                        tempPos.X += speed * dt;
                        if (!Obstacle.DidCollide(tempPos, radius))
                        {
                            position.X += speed * dt;
                        }
                        break;
                    default:
                        break;
                }
            }


            if (kState.IsKeyDown(Keys.Space) && kStateOld.IsKeyUp(Keys.Space))
            {
                Projectile.projectiles.Add(new Projectile(Position, direction));

            }
            kStateOld = kState;
        }
    }
}
