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
        public Vector2 position = defaultPosition;
        public float Speed { get; set; } = 180;
        static public Vector2 defaultPosition = new Vector2(640, 360);

        public void ShipUpdate(GameTime gameTime, Controller controller)
        {
            // To protect the game from lagging we take the elapsed time and multiply it be the speed
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState kState = Keyboard.GetState();

            if (controller.inGame)
            {
                if (kState.IsKeyDown(Keys.Right)&& position.X < 1280)
                {
                    position.X += Speed * dt;
                }
                if (kState.IsKeyDown(Keys.Left) && position.X > 0)
                {
                    position.X -= Speed * dt;
                }
                if (kState.IsKeyDown(Keys.Down)&& position.Y < 720)
                {
                    position.Y += Speed * dt;
                }
                if (kState.IsKeyDown(Keys.Up)&& position.Y > 0)
                {
                    position.Y -= Speed * dt;
                }
            }
        }
    }
}
