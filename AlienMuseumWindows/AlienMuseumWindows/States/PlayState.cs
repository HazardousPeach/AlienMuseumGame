

using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace AlienMuseumGame{
  public class PlayState : GameState {
    static String[] levels = { "testlevel" };
    Level curLevel;
    Camera camera;
    public PlayState(int levelnum, SpriteBatch batch){
			curLevel = Game1.levels[levels[levelnum]];
      camera = new Camera(batch, new Vector2(800,600), new Vector2(800,600));
    }
    public override void Update(){
      curLevel.updateEnts();
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
      public List<Wall> getWalls() { return curLevel.getWalls(); }
  }
}
