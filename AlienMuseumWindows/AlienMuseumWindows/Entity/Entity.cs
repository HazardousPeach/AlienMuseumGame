
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TiledMax;
using System.Collections.Generic;
using System;

namespace AlienMuseumGame{
  public abstract class Entity : GraphicsObject{
    public delegate Entity EntityFactory(Vector2 position, Properties properties);
    private static Dictionary<String, EntityFactory> factories = new Dictionary<String, EntityFactory>();
    Vector2 position;
    
    public static Entity MakeEnt(String typename, Vector2 position, Properties properties){
      if (factories.ContainsKey(typename)){
	return factories[typename](position,properties);
      }
      throw new ArgumentException("Unrecognized Entity Type: " + typename);
    }
    // A callback allowing you to register entities for creation.
    public static void RegisterEntity(String name, EntityFactory template){
			factories.Add(name, template);
    }
    public Vector2 getPosition(){ return position; }
    public abstract Texture2D getTexture();
	public abstract Rectangle getFinalRectangle();
  }
}
