using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame {
	public interface GraphicsObject{
	  	    Texture2D getCurrentFrame();
		    Vector2 getPosition();
		    float getRotation();
	  }
}