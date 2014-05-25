
using Microsoft.Xna.Framework;
using TiledMax;

namespace AlienMuseumGame{
  public class Entity : GraphicsObject{
    public delegate Entity EntityFactory(Vector2 position, Properties properties);
    private static Dictionary<String, EntityFactory> factories = new Dictionary<String, Entity>();
    
    public static Entity MakeEnt(String typename, Vector2 position, Properties properties){
      if (factories.ContainsKey(typename)){
	return factories[typename](position,properties);
      }
      throw new ArgumentException("Unrecognized Entity Type: " + typename);
    }
    // A callback allowing you to register entities for creation.
    public static void RegisterEntity(String name, EntityFactory template){
      templates.add(name, template);
    }
  }
}
