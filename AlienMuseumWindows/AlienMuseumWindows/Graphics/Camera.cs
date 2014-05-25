using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Text;

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
				Vector2 pos = obj.getPosition ();
				Rectangle rect = obj.getFinalRectangle ();
				if(pos.X + rect.Width > viewport.Left &&
					pos.X < viewport.Right &&
					pos.Y < viewport.Bottom &&
					pos.Y + rect.Height > viewport.Top)
		     {
					Texture2D tex = obj.getTexture ();
					Vector2 position = obj.getPosition();
					sb.Draw(tex, position, Color.White);
		     }
		   }

		   sb.End();
		 }

         public void DrawString(List<TextObject> objects)
         {
             sb.Begin();
             foreach (var obj in objects)
             {
                     sb.DrawString(obj.Font, obj.String, new Vector2 (obj.Position.X,obj.Position.Y), obj.Color, 0.0, new Vector2(0, 0), new Vector2 (obj.Scale.X,obj.Scale.Y), new SpriteEffect(null), 0.0);
                 
             }

             sb.End();
         }
		 private Vector2 worldToScreen(Vector2 point){
			return Vector2.Zero;
		 }
	  
	  }
}
