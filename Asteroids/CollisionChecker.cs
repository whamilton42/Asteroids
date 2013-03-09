using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Asteroids
{
    static class CollisionChecker
    {
        public static void perform(ArrayList entities)
        {
            foreach(Entities.Entity entity in entities)
            {
                foreach (Entities.Entity otherEntity in entity.otherEntities(entities))
                {
                    if(entity.isCollidingWith(otherEntity))
                    {
                        entity.collideWith(otherEntity);
                    }
                }
            }
        }
    }
}
