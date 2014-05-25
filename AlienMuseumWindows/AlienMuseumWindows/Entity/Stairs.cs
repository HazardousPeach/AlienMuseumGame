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
using System.Collections.Generic;


namespace AlienMuseumGame
{
    
    class Stairs : Entity
    {

        static Stairs()
        {
            Entity.RegisterEntity("Stairs", MakeStairs);
        }
        public Stairs(Vector2 position)
        {

            this.position = position;


        }
        public static Stairs MakeStairs(Vector2 position, Dictionary<String, String> diction){
            return new Stairs(position);
        }
        public bool canNextLevel()
        {
            Rectangle rect =Game1.pl1.getFinalRectangle();
			if(position.X + rect.Width >rect.X &&
				position.X < rect.X + rect.Width &&
				position.Y < rect.Y + rect.Height &&
				position.Y + rect.Height > rect.Y){
     
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
    
    

