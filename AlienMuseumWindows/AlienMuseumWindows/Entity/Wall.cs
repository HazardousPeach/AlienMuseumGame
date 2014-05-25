using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
    class Wall : Entity{
        
        private Dictionary<String, String> Diction;
        
        public Wall(Dictionary<String, String> Diction){
            this.Diction = Diction;
        }
        
        public Wall(Vector2 position){
            this.position = position;
        }
        
        public static Wall MakeWall(Vector2 position, Dictionary<string, string> Diction){
            return new Wall(Diction);
        }
        
        static Wall(){
            Entity.RegisterEntity("Wall", MakeWall);

        }
        public Vector2 getWallLoc()
        {
            return position;
     
        }
    }
    
}
