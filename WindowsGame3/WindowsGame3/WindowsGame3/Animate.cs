using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame3
{
    public class Animate
    {
        public Texture2D Texture {get; set;}
        public int Rows {get; set;}
        public int Columns { get; set; }
        private int currentFrames;
        private int totalFrames;

        public Animate(Texture2D texture, int rows, int columns){
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrames = 0;
            totalFrames = Rows * Columns;
        }
        public void Update(){
            currentFrames++;
            if (currentFrames == totalFrames) {
                currentFrames = 0;
            }

        }
        public void Reset() {
            currentFrames = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location) {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrames / (float)Columns);
            int column = currentFrames % Columns;
            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
        }

    }
}
