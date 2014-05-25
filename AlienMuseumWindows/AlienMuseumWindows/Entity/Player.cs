using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AlienMuseumGame{
  public class Player : AnimatedSprite{
		public bool positionSet = false;
    public Player(Vector2 position) : base(Game1.textures["player"], 1,7, 5){
			this.position = position;
    }
    public static Player MakePlayer(Vector2 position, Dictionary<string, string> properties){
      return new Player(position);
    }
       
        
    public override void Update(){
			if (!positionSet){
				position *= new Vector2 (Tile.tileset.TileWidth, Tile.tileset.TileHeight);
				positionSet = true;
			}
			PlayState state = (Game1.gameState as PlayState);
			if (state.curPlayer == null)
				state.curPlayer = this;
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
