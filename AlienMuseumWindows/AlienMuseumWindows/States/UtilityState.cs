using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace AlienMuseumGame
{
    public class UtilityState : GameState {
        Utility curUtility;
        SpriteBatch sb;
        //Used for the Draw functionality
        Camera camera;

        public UtilityState(int level, SpriteBatch batch)
        {
            sb = batch;
            curUtility = new Utility(level);
            camera = new Camera(batch, new Vector2(800, 600), new Vector2(800, 600));
        }
        public override void Draw()
        {
            camera.Draw(curUtility.getDrawables());
            camera.DrawString(curUtility.getTexts());
            
        }
        public override void Update()
        {
            switch(curUtility.updateEvents()){
                    case(-1):
                        break;
                    case (0):
                        {
                            Game1.ChangeGameStatePlay(0, sb);
                            break;
                        }
                    case (1):
                        {
                            Game1.ChangeGameStateUtility(1, sb);
                            break;
                        }
                    case (2):
                        {
                            Game1.ChangeGameStateUtility(2, sb);
                            break;
                        }
                    case (3):
                        break;
                    case (4):
                        {
                            Game1.ChangeGameStateUtility(0, sb);
                            break;
                        }
                }
                  
            }

        }

    }

