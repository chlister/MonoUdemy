using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RPG
{
   public class Projectile
    {
        private Vector2 position;
        private int speed = 800;
        private int radius = 15;
        private Dir direction;
        private bool collided = false;

        public static List<Projectile> projectiles = new List<Projectile>();

        public Vector2 Postition { get => position; private set => position = value; }
        public int Radius { get => radius; private set => radius = value; }
        public bool Collided { get => collided; set => collided = value; }

        public Projectile(Vector2 newPos, Dir newDir)
        {
            position = newPos;
            direction = newDir;
        }

        public void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (direction)
                {
                    case Dir.Up:
                        position.Y -= speed * dt;
                        break;
                    case Dir.Down:
                        position.Y += speed * dt;
                        break;
                    case Dir.Left:
                        position.X -= speed * dt;
                        break;
                    case Dir.Right:
                        position.X += speed * dt;
                        break;
                    default:
                        break;
                }
        }
    }
}
