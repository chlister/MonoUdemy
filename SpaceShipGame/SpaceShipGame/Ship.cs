using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipGame
{
    public class Ship
    {
        public Vector2 position = new Vector2(100, 100);
        public float Speed { get; set; } = 180;

        public void ShipUpdate(GameTime gameTime)
        {
            // To protect the game from lagging we take the elapsed time and multiply it be the speed
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState kState = Keyboard.GetState();

            if (kState.IsKeyDown(Keys.Right))
            {
                position.X += Speed * dt;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                position.X -= Speed * dt;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                position.Y += Speed * dt;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                position.Y -= Speed * dt;
            }
        }
    }
}
