using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame {
	  interface GraphicsObject{

          Vector2 getPosition();
          Vector2 getSize();
          Texture2D getTexture();
          Rectangle getFinalRectangle();

	  }
}