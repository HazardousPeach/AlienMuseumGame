using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
<<<<<<< HEAD
  public class Player : AnimatedSprite{

    /* static Player(){ */
    /*   Entity.RegisterEntity("player", MakePlayer); */
    /* } */
=======
	public class Player : AnimatedSprite{
    
    static Player(){
      Entity.RegisterEntity("player", MakePlayer);
    }
>>>>>>> 67fa25b29adda5e3ccb57bf3a4581e3fd368aed6
     
    
    public Player(Vector2 position) : base(Game1.textures["player"], 1,7, 5){
      this.position = position;
      (Game1.gameState as PlayState).getLevel().curPlayer = this;
    }
    public static Player MakePlayer(Vector2 position, Dictionary<string, string> properties){
      return new Player(position);
    }
<<<<<<< HEAD
=======
		public static Player MakePlayer(Vector2 position, Dictionary<string, string> properties){
	return new Player(position);
      }
       
        
        
>>>>>>> 67fa25b29adda5e3ccb57bf3a4581e3fd368aed6
    public override void Update(){
      (Game1.gameState as PlayState).
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
      if (dPos != Vector2.Zero)
	base.Update ();
      this.position += dPos;
    }
  }
}
