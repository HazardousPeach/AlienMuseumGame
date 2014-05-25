using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienMuseumGame
{
    public abstract class GameState
    {
        public GameState()
        {       
        }
        public abstract void Draw();
        public abstract void Update();
    }
}
