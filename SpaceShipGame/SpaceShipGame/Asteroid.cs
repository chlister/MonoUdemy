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
        private int radius = 59;
        private float speed = 220;
        private Vector2 position = new Vector2(600, 300);
        public Vector2 Position { get { return position; } set { position = value; } }
        public float Speed { get { return speed; } set { speed = value; } }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public void AsteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= Speed * dt;
        }
    }
}
