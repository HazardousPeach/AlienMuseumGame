

namespace AlienMuseumGame{
  public class PlayState : GameState {
    static const String[] levelpaths = { "testlevel1.tmx" }
    Level curLevel;
    Camera camera;
    public PlayState(int levelnum, SpriteBatch batch){
      curLevel = new Level(levelpaths[levelnum]);
      camera = new Camera(batch, new Vector2(800,600), new Vector2(800,600));
    }
    public override void Update(){
      curLevel.updateEnts();
    }
    public override void Draw(){
      camera.draw(curLevel.getDrawables());
    }
  }
}