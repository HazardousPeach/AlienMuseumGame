using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame{
  public class Player : Entity{
    
    Texture2D playerTex;
    Vector2 pos;
    
    public Player(Texture2D texture){
      playerTex = texture;
      pos = Vector2.Zero;
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
    public override Texture2D getTexture(){ return playerTex;}
    public override Rectangle getFinalRectangle(){ return new Rectangle(0,0,playerTex.Width, playerTex.Height); }
  }
}
