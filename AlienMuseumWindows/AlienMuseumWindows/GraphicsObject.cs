using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame {
	  interface GraphicsObject{
	  	    Texture2D getCurrentFrame();
		    Vector2D getPosition();
		    float getRotation();
	  }
}