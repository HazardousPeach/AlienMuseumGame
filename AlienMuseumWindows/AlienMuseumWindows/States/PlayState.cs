

using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;


namespace AlienMuseumGame{
  public class PlayState : GameState {
    static String[] levels = { "testlevel" };
		Level curLevel;
    Camera camera;
    public Player curPlayer;
    public PlayState(int levelnum, SpriteBatch batch){
			curLevel = Game1.levels[levels[levelnum]];
      camera = new Camera(batch, new Vector2(800,600), new Vector2(800,600));
    }
    
    public override void Update(){
			curLevel.updateEnts();
			Vector2 playerPos = 
			camera.display = new Rectangle(curLevel.get
    }
    public override void Draw(){
			curLevel.DrawBackground(camera);
			camera.Draw(curLevel.getDrawables());
    }
  }
}
