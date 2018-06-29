using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
namespace RPG
{
public   abstract class Obstacle
    {
        private Vector2 position;
        private int radius;
        private Vector2 hitPos;
        public static List<Obstacle> obstacles = new List<Obstacle>();

        public Vector2 Position { get => position; protected set => position = value; }
        public int Radius { get => radius; protected set => radius = value; }
        public Vector2 HitPos { get => hitPos; set => hitPos = value; }

        public Obstacle(Vector2 newPos)
        {
            position = newPos;
        }
        public static bool DidCollide(Vector2 otherPos, int otherRad)
        {
            foreach (Obstacle o in Obstacle.obstacles)
            {
                int sum = o.Radius + otherRad;
                if (Vector2.Distance(o.hitPos, otherPos) < sum)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Tree : Obstacle
    {
        public Tree(Vector2 newPos) : base(newPos)
        {
            Radius = 40;
            HitPos = new Vector2(Position.X + 64, Position.Y + 128);
        }
    }

    class Bush : Obstacle
    {
        public Bush(Vector2 newPos) : base(newPos)
        {
            Radius = 32 ;
            HitPos = new Vector2(Position.X + 56, Position.Y + 57);
        }

    }
}
