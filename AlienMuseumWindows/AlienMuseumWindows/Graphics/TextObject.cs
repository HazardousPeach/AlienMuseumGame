using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienMuseumGame
{
    public struct TextObject
    {
        public TextObject(Vector2 Position, Color Color, Vector2 Scale, SpriteFont Font, StringBuilder String)
        {
            this.Position = Position;
            this.Color = Color;
            this.Scale = Scale;
            this.Font = Font;
            this.String = String;
        }
        public Vector2 Position;

        public Color Color;

        public Vector2 Scale;

        public SpriteFont Font;

        public StringBuilder String;
    }
    
}
