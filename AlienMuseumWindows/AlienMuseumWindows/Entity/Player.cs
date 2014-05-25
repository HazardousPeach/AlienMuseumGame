using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

namespace AlienMuseumGame
{
    public class Player : AnimatedSprite
    {
        public bool positionSet = false;
        public Player(Vector2 position)
            : base(Game1.textures["player"], 1, 7, 5)
        {
            this.position = position;
        }
        public static Player MakePlayer(Vector2 position, Dictionary<string, string> properties)
        {
            return new Player(position);
        }


        public override void Update()
        {
            if (!positionSet)
            {
                position *= new Vector2(Tile.tileset.TileWidth, Tile.tileset.TileHeight);
                positionSet = true;
            }
            PlayState state = (Game1.gameState as PlayState);
            if (state.curPlayer == null)
                state.curPlayer = this;
            float speed = 7.0f;
            Vector2 dPos = Vector2.Zero;
            KeyboardState keystate = Keyboard.GetState();

            if (keystate.IsKeyDown(Keys.A))
            {
                dPos += new Vector2(-speed, 0.0f);
            }
            if (keystate.IsKeyDown(Keys.S))
            {
                dPos += new Vector2(0.0f, speed);
            }
            if (keystate.IsKeyDown(Keys.D))
            {
                dPos += new Vector2(speed, 0.0f);
            }
            if (keystate.IsKeyDown(Keys.W))
            {
                dPos += new Vector2(0.0f, -speed);
            }
            List<Wall> mapWalls = ((PlayState)Game1.gameState).getWalls();
            Rectangle rect = this.getFinalRectangle();
            foreach (Wall i in mapWalls)
            {
                if (dPos.X < 0)
                {
                    if (64 + i.getPosition().X < rect.X - dPos.X)
                    {
                        dPos.X = i.getPosition().X + 64;
                    }
                }
                else if(i.getPosition().X - (rect.X + rect.Width) < dPos.X)
                {
                    dPos.X = i.getPosition().X - (rect.X + rect.Width);
                }

                if (dPos.Y < 0)
                {
                    if (rect.Y - 64 < dPos.Y)
                    {
                        dPos.Y = rect.Y - 64;
                    }
                }
                else
                {
                    if (i.getPosition().Y - (rect.Y + rect.Height) < dPos.Y)
                    {
                        dPos.Y = i.getPosition().Y - (rect.Y + rect.Height);
                    }
                }






                this.position += dPos;
                if (Math.Abs(dPos.X) >= Math.Abs(dPos.Y))
                {
                    if (dPos.X < 0)
                        this.CurrentAnim = 2;
                    else if (dPos.X > 0)
                        this.CurrentAnim = 3;
                }
                else
                {
                    if (dPos.Y < 0)
                        this.CurrentAnim = 0;
                    else
                        this.CurrentAnim = 1;
                }
            }
        }
    }
}
