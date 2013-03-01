using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids.Entities
{
    class Entity
    {
        public Sprite sprite;

        public void setSprite(Game1 game, String imagePath)
        {
            sprite = new Sprite(game, imagePath);
        }
    }
}
