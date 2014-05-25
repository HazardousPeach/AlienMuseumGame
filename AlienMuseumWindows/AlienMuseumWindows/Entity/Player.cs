using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using TiledMax;

namespace AlienMuseumGame{
  public class Player : Entity{
    
    public static Texture2D PlayerTex {get;set;}
    Vector2 pos;

    static Player(){
      Entity.RegisterEntity("player", MakePlayer);
    }
     
    
    private Player(Vector2 position){
      pos = position;
    }
      public static Player MakePlayer(Vector2 position, Properties properties){
	return new Player(position);
      }
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
    public override Texture2D getTexture(){ return PlayerTex;}
    public override Rectangle getFinalRectangle(){ return new Rectangle(0,0,PlayerTex.Width, PlayerTex.Height); }
  }
}
