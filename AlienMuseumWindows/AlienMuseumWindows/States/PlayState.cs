

using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace AlienMuseumGame{
  public class PlayState : GameState {
		static String[] levels = { "Tutorial" };
		Level curLevel;
    Camera camera;
    public Player curPlayer;
		Overlay over;
    public PlayState(int levelnum, SpriteBatch batch){
			curLevel = Game1.levels[levels[levelnum]];
      camera = new Camera(batch, new Vector2(800,600), new Vector2(800,600));
			over = new Overlay (camera);
    }
		private class Overlay : GraphicsObject{
			Camera cam_;
			Texture2D tex;
			public Overlay(Camera cam){ 
				cam_ = cam;
				tex = Game1.textures["overlay"];
			}
			public Vector2 getPosition(){return new Vector2(cam_.viewport.X, cam_.viewport.Y);}
			public Texture2D getTexture() {
				return tex;
			}
			public Rectangle getFinalRectangle(){
				return new Rectangle (0, 0, tex.Width, tex.Height);
			}
		}
    public override void Update(){
			curLevel.updateEnts();
			Vector2 playerPos = curPlayer.getPosition();
			camera.viewport = new Rectangle((int)playerPos.X + curPlayer.Texture.Width / curPlayer.Columns / 2 - (camera.viewport.Width / 2),
				(int)playerPos.Y + curPlayer.Texture.Height / curPlayer.Columns / 2 - (camera.viewport.Height / 2), camera.viewport.Width, camera.viewport.Height);
    }
    public override void Draw(){
			curLevel.DrawBackground(camera);
			List<GraphicsObject> drawables = new List<GraphicsObject> (curLevel.getDrawables ());
			drawables.Add (over);
			camera.Draw(drawables);
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
