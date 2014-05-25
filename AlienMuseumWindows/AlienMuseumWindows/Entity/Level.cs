
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using TiledMax;

namespace AlienMuseumGame {
  public class Level : GraphicsObject {
    Map levelmap;
    List<Entity> levelEnts;
    Texture2D background;
    public Level(String levelpath, Graphics g){
      try{
	levelmap = Map.Open(levelpath);
	background = convertBitmap(levelMap.DrawGdiPreview(true));
	foreach(ObjectGroup grp in levelmap.ObjectGroups){
	  foreach(MapObject mo in grp){
	    Entity ent = Entity.MakeEnt(mo.Type, new Vector2(mo.X,mo.Y) mo.Properties);
	    levelEnts.add(ent);
	  }
	}
				
      } finally {
	filestream.Close();
      }
    }
    public List<GraphicsObject> getDrawables(){
      List<GraphicsObject> drawables = new List<GraphicsObject>();
      drawables.add(this);
      drawables.addRange(levelEnts);
    }
    private Texture2D convertBitmap(Bitmap bmp, Graphics g){

      Color[] pixels = new Color[bmp.Width * bmp.Height];
      for (int y = 0; y < bmp.Height; y++)
      {
	for (int x = 0; x < bmp.Width; x++)
	{
	  System.Drawing.Color c = bmp.GetPixel(x, y);
	  pixels[(y * bmp.Width) + x] = new Color(c.R, c.G, c.B, c.A);
	}
      }
		 	
      Texture2D result = new Texture2D(
	g.GraphicsDevice, 
	bmp.Width, 
	bmp.Height, 
	1,
	ResourceUsage.None,
	SurfaceFormat.Color);
		 	
      myTex.SetData<Color>(pixels);
      return myTex;
    }
  }
}
