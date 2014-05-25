using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame {
	  interface GraphicsObject{

          Vector2 getPosition();
          Texture2D getTexture();
          Rectangle getFinalRectangle();

	  }
}