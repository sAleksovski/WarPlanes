﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CarrierAirWing
{
    public class Explosion
    {
        public Bitmap Sprite { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Status { get; set; }
        private int ticks;
        private int currentSprite;
        private int spriteIndex;

        public Explosion(int x, int y)
        {
            X = x;
            Y = y;
            ticks = 2;
            spriteIndex = GraphicsEngine.randomizer.Next(2);
            currentSprite = 0;
            Status = 0;
            Sprite = GraphicsEngine.explosionSprites[spriteIndex][currentSprite];
            SoundEngine.PlayExplosionSound(@"sounds\explosions\explosion1.mp3");
        }

        public void Move()
        {
            if (ticks == 0)
            {
                ticks = 2;
                currentSprite++;

                if (currentSprite >= GraphicsEngine.explosionSprites[spriteIndex].Length)
                    Status = -1;
                else
                    Sprite = GraphicsEngine.explosionSprites[spriteIndex][currentSprite];
            }
            else
            {
                ticks--;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Sprite, X - Sprite.Width / 2, Y -Sprite.Height / 2);
        }
    }
}
