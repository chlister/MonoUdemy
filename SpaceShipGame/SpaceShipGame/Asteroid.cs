using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipGame
{
    public class Asteroid
    {
        static Random rand = new Random();
        private float speed;
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; } }
        public float Speed { get { return speed; } set { speed = value; } }

        public int Radius { get; set; } = 59;

        public Asteroid(float newSpeed)
        {
            Speed = newSpeed;
            Position = new Vector2(1280 + Radius, rand.Next(0, 720 + 1));
        } 

        public void AsteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= Speed * dt;
        }
    }
}
