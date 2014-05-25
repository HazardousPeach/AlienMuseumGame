using Microsoft.Xna.Framework;
using Microsoft.Xna.Graphics;

namespace AlienMuseumGame{
	  public class Camera {
	  	 private SpriteBatch sb;
		 private Rectangle display;
		 private Rectangle viewport;
		 public Camera(SpriteBatch batch, Vector2 displayDimensions, Vector2 viewportDimensions){
		 	sb = batch;
			display = new Rectangle(0,0, displayDimensions.X, displayDimensions.Y);
			viewport = new Rectangle(0,0, viewportDimensions.X, viewportDimensions.Y);
		 }
		 public void Draw(List<GraphicsObject> objects){
		 	foreach(GraphicsObject obj in objects){
			}
		 }
		 private Vector2D worldToScreen(Vector2D point){
		 	 
		 }
	  
	  }
}