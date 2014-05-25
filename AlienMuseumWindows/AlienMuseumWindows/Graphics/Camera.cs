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
		 	foreach(GraphicsObject obj in objects){
			}
		 }
		 private Vector2 worldToScreen(Vector2 point){
			return Vector2.Zero;
		 }
	  
	  }
}