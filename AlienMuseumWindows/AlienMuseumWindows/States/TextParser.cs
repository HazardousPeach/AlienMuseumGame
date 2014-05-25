using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlienMuseumGame
{
    public class TextParser
    {
        public List<TextObject> parsed;
        public TextParser(string unparsed)
        {
            string[] splitString = unparsed.Split(new Char[] { '|' });
            int i = 0;
            int j = 0;
            string[] z = new string[4];
            foreach (string o in splitString)
            {
                //String,Positionx,Positiony,Scalex,Scaley
                z[i % 5] = o;
                i++;
                if (i % 5 == 0)
                    parsed.Add(new TextObject(new Vector2(float.Parse(z[1]), float.Parse(z[2])), Color.Green, new Vector2(float.Parse(z[3]), float.Parse(z[4])), Game1.Terminal, new StringBuilder().Append(z[0])));
            }
        }
    }
}
