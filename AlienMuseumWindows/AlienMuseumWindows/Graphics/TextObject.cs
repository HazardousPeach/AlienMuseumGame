using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienMuseumGame
{
    public interface TextObject
    {
        Vector2 getPosition();

        SpriteFont getFont();

        String getString();

        Rectangle getFinalRectangle();
    }
}
