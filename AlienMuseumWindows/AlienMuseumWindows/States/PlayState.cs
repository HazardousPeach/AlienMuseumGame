

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
			Vector2 playerPos = curPlayer.getPosition();
			camera.viewport = new Rectangle((int)playerPos.X + curPlayer.Texture.Width / curPlayer.Columns / 2 - (camera.viewport.Width / 2),
				(int)playerPos.Y + curPlayer.Texture.Height / curPlayer.Columns / 2 - (camera.viewport.Height / 2), camera.viewport.Width, camera.viewport.Height);
    }
    public override void Draw(){
			curLevel.DrawBackground(camera);
			camera.Draw(curLevel.getDrawables());
    }
    public Level getLevel()
    {
        return curLevel;
    }
      public void FinishLevel(int levelnum)
    {
        Game1.ChangeGameStateUtility(levelnum, camera.sb);
    }
  }
}
