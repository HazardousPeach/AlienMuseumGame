
using System.IO;
using System.Collections.Generic;
using TiledMax;
using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace AlienMuseumGame {
  public class Level : GraphicsObject {
    Map levelMap;
    List<Entity> levelEnts;
    Texture2D background;
    public Level(String levelpath, GraphicsDeviceManager g){
      levelMap = Map.Open(levelpath);
      background = convertBitmap(levelMap.DrawGdiPreview(true), g.GraphicsDevice);
      foreach(ObjectGroup grp in levelMap.ObjectGroups){
	foreach(MapObject mo in grp){
	  Entity ent = Entity.MakeEnt(mo.Type, new Vector2(mo.X,mo.Y), mo.Properties);
	  levelEnts.Add(ent);
	}
      }

    }
    public List<GraphicsObject> getDrawables(){
      List<GraphicsObject> drawables = new List<GraphicsObject>();
      drawables.Add(this);
      drawables.AddRange(levelEnts);
      return drawables;
    }
    private Texture2D convertBitmap(System.Drawing.Bitmap bmp){

      Color[] pixels = new Color[bmp.Width * bmp.Height];
      for (int y = 0; y < bmp.Height; y++)
      {
	for (int x = 0; x < bmp.Width; x++)
	{
	  System.Drawing.Color c = bmp.GetPixel(x, y);
	  pixels[(y * bmp.Width) + x] = new Color(c.R, c.G, c.B, c.A);
	}
      }
      Texture2D result = new Texture2D(GraphicsDevice, bmp.Width, bmp.Height, false, SurfaceFormat.Color);
		 	
      result.SetData<Color>(pixels);
      return result;
    }
    public void updateEnts() {
      foreach(Entity ent in levelEnts){
	ent.Update();
      }
    }
    public Vector2 getPosition() { return Vector2.Zero;}
    public Texture2D getTexture() { return background; }
    public Microsoft.Xna.Framework.Rectangle getFinalRectangle() { return new Rectangle(0,0,background.Width, background.Height);}
  }
}
