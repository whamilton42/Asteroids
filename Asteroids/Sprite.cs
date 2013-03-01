using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
//using System.Windows.Shapes;

namespace Asteroids
{
    class Sprite
    {
        public Texture2D texture;
        public Vector2 position;
        public Vector2 velocity;
        //public Polygon hitbox;

        public Sprite(Game1 game, String contentName)
        {
            texture = game.Content.Load<Texture2D>(contentName);
            //hitbox = createHitbox();
        }

        public void setPosition(Vector2 position)
        {
            this.position = position;
        }

        public void transform(int rotation, int speed)
        {
            int newX = (int) (this.position.X + Math.Sin(speed));
            int newY = (int) (this.position.Y + Math.Cos(speed));
            this.setPosition(new Vector2(newX, newY));
        }

        private Color[,] TextureTo2DArray(Texture2D texture)
        {
            Color[] colors1D = new Color[texture.Width * texture.Height];
            texture.GetData(colors1D);

            Color[,] colors2D = new Color[texture.Width, texture.Height];
            for (int x = 0; x < texture.Width; x++)
                for (int y = 0; y < texture.Height; y++)
                    colors2D[x, y] = colors1D[x + y * texture.Width];

            return colors2D;
        }

        //public Polygon createHitbox()
        //{

        //    //hitbox = new Polygon();

        //    // Left to right.
        //    // Right to left.
        //    // Stop as soon as you hit non-transparent pixel. Log location.

        //    Color[,] textureColors = TextureTo2DArray(texture);

        //    for (int xCoord = 0; xCoord < texture.Height; xCoord++)
        //    {
        //        for (int yCoord = 0; yCoord < texture.Width; yCoord++)
        //        {

        //        }
        //    }

        //    for (int y_coord = texture.Height - 1; y_coord >= 0; y_coord--)
        //    {
        //        // Right to left.
        //        for (int x_coord = texture.Width - 1; x_coord >= 0; x_coord--)
        //        {
        //            //if (is_not_transparent(sprite.getRGB(x_coord, y_coord)))
        //            //{
        //            //    hitbox.addPoint(x_coord, y_coord);
        //            //    break;
        //            //}
        //        }
        //    }

        //    return hitbox;
        //}
    }
}
