using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AlienMuseumGame
{
    public class Utility : GraphicsObject
    {
        //Current Scene, Start Screen, Splash Screens etc.
        int level;
        //Selector used for start screen selection
        int cursor;
        SpriteFont font;
        Texture2D background;

        public Utility(int level){
            this.level = level;
            cursor = 0;

        }

        public List<GraphicsObject> getDrawables()
        {
            List<GraphicsObject> drawables = new List<GraphicsObject>();
            drawables.Add(this);
            //Could add more things to list if there was time ....
            return drawables;
        }
        public List<TextObject> getTexts()
        {
            List<TextObject> texts = new List<TextObject>();
            texts.Add(null);
            return texts;
        }
        public int updateEvents(){
            return cursor;
        }
        public Vector2 getPosition() { return Vector2.Zero;}
        public Texture2D getTexture() { return background; }
        public Microsoft.Xna.Framework.Rectangle getFinalRectangle() { return new Rectangle(0,0,background.Width, background.Height);}
    }
}
