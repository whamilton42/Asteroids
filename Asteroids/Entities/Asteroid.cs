using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Asteroids.Entities
{
    class Asteroid : Entities.Entity
    {
        private String size;

        public Asteroid(Game1 game, String size, Vector2 velocity, Vector2 position)
        {
            setSprite(game, "asteroid2");

            this.size = size;
            this.sprite.position = position;
            this.sprite.velocity = velocity;
        }

        public void tick(double milliseconds)
        {
            this.sprite.position += this.sprite.velocity * (int) milliseconds / 50;
        }
    }
}
