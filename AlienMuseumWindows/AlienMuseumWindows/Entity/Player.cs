using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
	public class Player : AnimatedSprite{
    
    static Player(){
      Entity.RegisterEntity("player", MakePlayer);
    }
     
    
		public Player(Vector2 position) : base(Game1.textures["player"], 1,7){
			this.position = position;
    }
		public static Player MakePlayer(Vector2 position, Dictionary<string, string> properties){
	return new Player(position);
      }
       
        
        
    public override void Update(){
			float speed = 7.0f;
      Vector2 dPos = Vector2.Zero;
      KeyboardState keystate = Keyboard.GetState();

      if (keystate.IsKeyDown(Keys.A))
      {
          dPos += new Vector2(-speed, 0.0f);
      }
      if (keystate.IsKeyDown(Keys.S))
      {
          dPos += new Vector2(0.0f, speed);
      }
      if (keystate.IsKeyDown(Keys.D))
      {
          dPos += new Vector2(speed, 0.0f);
      }
      if (keystate.IsKeyDown(Keys.W))
      {
          dPos += new Vector2(0.0f, -speed);
      }
      List<Wall> mapWalls = ((PlayState)Game1.gameState).getWalls();
      Rectangle rect = this.getFinalRectangle();
      foreach(Wall i in mapWalls){
          if (dPos.X < 0)
          {
              if (64 + i.getPosition().X < rect.X - dPos.X)
              {
                  dPos.X = i.getPosition().X + 64;

              }
          }
          else
          {
              if (i.getPosition().X - (rect.Width + rect.X) < dPos.X)
              {
                  dPos.X = i.getPosition().X - (rect.Width + rect.X);
              }
          }
          } 
        this.position += dPos;
    }
  }
}
