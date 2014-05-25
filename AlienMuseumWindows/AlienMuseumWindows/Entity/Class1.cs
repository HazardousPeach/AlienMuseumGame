using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using TiledMax;
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
        
        public static Wall makeWall(Vector2 position, Dictionary<string, string> Diction){
            return new Wall(Diction);
        }
        
        static Wall(){
            Entity.RegisterEntity("Wall", makeWall);

        }
    }
    
}
