﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AlienMuseumGame
{
	public class AnimatedSprite : Entity
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        public AnimatedSprite(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

		public override void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public Vector2 getSize()
        {
            return new Vector2(Texture.Width / Columns, Texture.Height / Rows);
        }
		public override Texture2D getTexture ()
		{
			return Texture;
		}
		public override Rectangle getFinalRectangle()
        {
			int rowNum = currentFrame / Columns;
			int remainder = currentFrame % Columns;
            return new Rectangle(remainder*(Texture.Width / Columns), rowNum*(Texture.Height / Rows), 
                Texture.Width / Columns, Texture.Height / Rows);
        }

    }
}