using TiledSharp;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienMuseumGame{
  public class Tile : GraphicsObject{
    public static TmxTileset tileset;
    Vector2 position;
    int id;
    public Tile(Vector2 pos, int ID){
			position = new Vector2(pos.X * tileset.TileWidth, pos.Y * tileset.TileHeight);
      id = ID; 
    }
    public Vector2 getPosition(){ return position;}
    public Texture2D getTexture(){ return Game1.textures[tileset.Image.Source];}
    public Rectangle getFinalRectangle(){
      int? numTilesVert = (tileset.Image.Height / tileset.TileHeight);
      int? numTilesHoriz = (tileset.Image.Width / tileset.TileWidth);
      int x = (int)(((id - 1)% (tileset.Image.Width / tileset.TileWidth)) * tileset.TileWidth);
      int y = (int)(tileset.TileHeight * ((id - 1)/ numTilesHoriz));

      return new Rectangle(x, y,tileset.TileWidth, tileset.TileHeight);
    }
  }
}
