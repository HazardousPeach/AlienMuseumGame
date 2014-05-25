
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
    List<Tile> levelTiles;
		public Level(String levelpath, ContentManager content){
      levelMap = new TmxMap("Content/" + levelpath);
      levelEnts = new List<Entity> ();
      foreach(TmxObjectGroup grp in levelMap.ObjectGroups){
	foreach(TmxObjectGroup.TmxObject mo in grp.Objects){
	  Entity ent = Entity.MakeEnt(mo.Type, new Vector2(mo.X,mo.Y), mo.Properties);
	  levelEnts.Add(ent);
	}
      }
      Tile.tileset = levelMap.Tilesets[0];
      foreach (TmxTileset tileset in levelMap.Tilesets) {
				string name = tileset.Image.Source.Substring(8,tileset.Image.Source.Length - 12);
				Game1.textures.Add (tileset.Image.Source, content.Load<Texture2D> (name));
      }
      levelTiles = new List<Tile> ();
      foreach(TmxLayer layer in levelMap.Layers){
	foreach(TmxLayerTile tile in layer.Tiles){
	  levelTiles.Add(new Tile(new Vector2(tile.X, tile.Y), tile.Gid));
	}
      }

    }
    public List<GraphicsObject> getDrawables(){
      List<GraphicsObject> drawables = new List<GraphicsObject>();
      drawables.AddRange(levelTiles);
      drawables.AddRange(levelEnts);
      return drawables;
    }
    public void updateEnts() {
      foreach(Entity ent in levelEnts){
	ent.Update();
      }
    }
    public void DrawBackground(Camera camera){
    }
    public List<Wall> getWalls()
    {
        List<Wall> walls = new List<Wall>();
        foreach (Wall w in levelEnts)
        {
            walls.Add(w);
        }
        return walls;
    }
  }
}
