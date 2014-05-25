using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
	  public class Camera {
	  	 private SpriteBatch sb;
		 private Rectangle display;
		 private Rectangle viewport;
		 public Camera(SpriteBatch batch, Vector2 displayDimensions, Vector2 viewportDimensions){
		 	sb = batch;
			display = new Rectangle(0,0, (int)displayDimensions.X, (int)displayDimensions.Y);
			viewport = new Rectangle(0,0, (int)viewportDimensions.X, (int)viewportDimensions.Y);
		 }
		 public void Draw(List<GraphicsObject> objects){
		   sb.Begin();
		   foreach(var obj in objects){
				Vector2 pos = obj.getPosition ();
				Rectangle rect = obj.getFinalRectangle ();
				if(pos.X + rect.Width > viewport.Left &&
					pos.X < viewport.Right &&
					pos.Y < viewport.Bottom &&
					pos.Y + rect.Height > viewport.Top)
		     {
		       sb.Draw(obj.getTexture(), new Vector2(obj.getPosition().X, obj.getPosition().Y), Color.White);
		     }
		   }

		   sb.End();
		 }

		 private Vector2 worldToScreen(Vector2 point){
			return Vector2.Zero;
		 }
	  
	  }
}
