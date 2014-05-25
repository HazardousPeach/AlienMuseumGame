using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using TiledMax;

namespace AlienMuseumGame{
	public class Player : Entity, GraphicsObject{
    
    public static Texture2D PlayerTex {get;set;}

    static Player(){
      Entity.RegisterEntity("player", MakePlayer);
    }
     
    
    public Player(Vector2 position){
			this.position = position;
    }
      public static Player MakePlayer(Vector2 position, Properties properties){
	return new Player(position);
      }
    public void Update(){
			float speed = 7.0f;
      Vector2 dPos = Vector2.Zero;
      KeyboardState keystate = Keyboard.GetState();

      if (keystate.IsKeyDown(Keys.A)) 
				dPos += new Vector2(-speed, 0.0f);
      if (keystate.IsKeyDown(Keys.S)) 
				dPos += new Vector2(0.0f, speed);
      if (keystate.IsKeyDown(Keys.D)) 
				dPos += new Vector2(speed, 0.0f);
      if (keystate.IsKeyDown(Keys.W)) 
				dPos += new Vector2(0.0f, -speed);

			this.position += dPos;
    }
    public override Texture2D getTexture(){ return PlayerTex;}
    public override Rectangle getFinalRectangle(){ return new Rectangle(0,0,PlayerTex.Width, PlayerTex.Height); }
  }
}
