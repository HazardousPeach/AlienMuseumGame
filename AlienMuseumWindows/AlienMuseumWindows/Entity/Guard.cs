using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using TiledMax;
using System.Collections.Generic;

namespace AlienMuseumGame
{
    class Guard : Entity
    {

        static Guard()
        {
            Entity.RegisterEntity("Guard", MakeGuard);
        }
        public Guard(Vector2 position)
        {
            this.position = position;
        }
        public static Guard MakeGuard(Vector2 position, Dictionary<String, String> diction)
        {
            return new Guard(position);
        }
        public bool flahLight()
        {
            Rectangle rect = new Game1.pl1.getFinalRectangle();
            if (position.X + rect.Width > rect.X &&
                position.X < rect.X + rect.Width &&
                position.Y < rect.Y + rect.Height &&
                position.Y + rect.Height > rect.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public override void Update()
        {
            if (flahLight().Equals(true))
            {
                PlayState Game = (PlayState)Game1.gameState;
                (Game1.gameState as PlayState).FinishLevel(2);
                
            }
            
            
        }
    }
}
