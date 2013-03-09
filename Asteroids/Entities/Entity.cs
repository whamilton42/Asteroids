using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Asteroids.Entities
{
    class Entity
    {
        public Sprite sprite;

        public void setSprite(Game1 game, String imagePath)
        {
            sprite = new Sprite(game, imagePath);
        }

        public Boolean isCollidingWith(Entities.Entity otherEntity)
        {
            return true;
        }

        public void collideWith(Entities.Entity otherEntity)
        {
        }

        public ArrayList otherEntities(ArrayList entities)
        {
            var otherEntities = new ArrayList(entities);
            otherEntities.Remove(this);

            return otherEntities;
        }
    }
}
