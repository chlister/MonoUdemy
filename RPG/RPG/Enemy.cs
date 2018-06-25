using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
namespace RPG
{
    public class Enemy
    {
        private Vector2 position;
        private int health;
        private int speed;
        private int radius;

        public static List<Enemy> enemies = new List<Enemy>();

        public Vector2 Position { get => position; private set => position = value; }
        public int Health { get => health; set => health = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Radius { get => radius; protected set => radius = value; }

        public Enemy(Vector2 newPos)
        {
            Position = newPos;
        }

        public void Update(GameTime gameTime, Vector2 playerPos)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Vector2 moveDir = playerPos - position;
            moveDir.Normalize();

            Vector2 tempPos = position;

            tempPos += moveDir * speed * dt;
            if (!Obstacle.DidCollide(tempPos, radius))
            {
                position += moveDir * speed * dt;
            }
        }
    }

    class Snake : Enemy
    {
        public Snake(Vector2 newPos) : base(newPos)
        {
            Speed = 120;
            Radius = 42;
            Health = 3;
        }
    }

    class Eye : Enemy
    {
        public Eye(Vector2 newPos) : base(newPos)
        {
            Speed = 80;
            Radius = 45;
            Health = 5;
        }
    }
}
