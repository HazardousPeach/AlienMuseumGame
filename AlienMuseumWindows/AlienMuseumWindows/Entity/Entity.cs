
using Microsoft.Xna.Framework;
using TiledMax;

namespace AlienMuseumGame{
  public class Entity : GraphicsObject{
    public static Entity MakeEnt(String typename, Vector2 Position, Properties properties){
      throw new ArgumentException("Unrecognized Entity Type: " + typename);
    }
  }
}
