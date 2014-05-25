
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using TiledSharp;

namespace AlienMuseumGame {
  public class Level {
		TmxMap levelMap;
    List<Entity> levelEnts;
    public Level(String levelpath, ContentManager content){
			levelMap = new TmxMap("Content/" + levelpath);
      levelEnts = new List<Entity> ();
			foreach(TmxObjectGroup grp in levelMap.ObjectGroups){
				foreach(TmxObjectGroup.TmxObject mo in grp.Objects){
	  Entity ent = Entity.MakeEnt(mo.Type, new Vector2(mo.X,mo.Y), mo.Properties);
	  levelEnts.Add(ent);
	}
      }

    }
    public List<GraphicsObject> getDrawables(){
      List<GraphicsObject> drawables = new List<GraphicsObject>();
      drawables.AddRange(levelEnts);
      return drawables;
    }
    public void updateEnts() {
      foreach(Entity ent in levelEnts){
	ent.Update();
      }
    }
    public void DrawBackground(Camera camera){
			//levelMap.Draw(camera.sb, camera.display, new Vector2(camera.viewport.X, camera.viewport.Y));
    }
  }
}
