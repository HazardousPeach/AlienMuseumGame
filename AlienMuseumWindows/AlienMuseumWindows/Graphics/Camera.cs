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
		 public void Draw(SpriteBatch spriteBatch, List<GraphicsObject> objects){
             spriteBatch.Begin();
             foreach(GraphicsObject obj in objects){
                 if(obj.getPosition().X + obj.getFinalRectangle().Width > viewport.Left &&
                     obj.getPosition().X < viewport.Right &&
                     obj.getPosition().Y > viewport.Bottom &&
                     obj.getPosition().Y + obj.getFinalRectangle().Height > viewport.Top)
                 {
                     spriteBatch.Draw(obj.getTexture(), new Vector2(obj.getPosition().X, obj.getPosition().Y), Color.White);
                 }
			}

             spriteBatch.End();
		 }

		 private Vector2 worldToScreen(Vector2 point){
			return Vector2.Zero;
		 }
	  
	  }
}