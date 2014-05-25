using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
	  public class Camera {
	  	 public SpriteBatch sb;
		 public Rectangle display;
		 public Rectangle viewport;
		 public Camera(SpriteBatch batch, Vector2 displayDimensions, Vector2 viewportDimensions){
		 	sb = batch;
			display = new Rectangle(0,0, (int)displayDimensions.X, (int)displayDimensions.Y);
			viewport = new Rectangle(0,0, (int)viewportDimensions.X, (int)viewportDimensions.Y);
		 }
		 public void Draw(List<GraphicsObject> objects){
		   sb.Begin();
		   foreach(var obj in objects){
				Vector2 pos = obj.getPosition() - new Vector2(viewport.X, viewport.Y);;
				Rectangle rect = obj.getFinalRectangle ();
				if(pos.X + rect.Width > 0 &&
					pos.X < viewport.Width &&
					pos.Y < viewport.Height &&
					pos.Y + rect.Height > 0)
		     {
					Texture2D tex = obj.getTexture ();
					sb.Draw(tex, pos,
						rect, Color.White);
		     }
		   }

		   sb.End();
		 }

		 private Vector2 worldToScreen(Vector2 point){
			return Vector2.Zero;
		 }
	  
	  }
}
