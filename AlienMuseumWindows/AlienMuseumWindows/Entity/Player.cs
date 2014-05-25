using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace AlienMuseumGame{
	  public class Player : GraphicsObject{
	  	 public Player(Texture2D texture){
		 	playerTex = texture;
			pos = Vector2.Zero;
		 }
	  	 Texture2D playerTex;
		 Vector2 pos;
		 public void Update(){
		 	float speed = 3.0f;
			Vector2 dPos = Vector2.Zero;
			KeyboardState keystate = Keyboard.GetState();

			if (keystate.IsKeyDown(Keys.A)) dPos += new Vector2(-speed, 0.0f);
			if (keystate.IsKeyDown(Keys.S)) dPos += new Vector2(0.0f, speed);
			if (keystate.IsKeyDown(Keys.D)) dPos += new Vector2(speed, 0.0f);
			if (keystate.IsKeyDown(Keys.W)) dPos += new Vector2(0.0f, -speed);

			pos += dPos;
		 }
	  }
}