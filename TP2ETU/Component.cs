using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        //protected Texture playerTexture = null;
        // protected Sprite playerSprite = null;
        

        public abstract void SetSprite();
        public abstract void SetWeapon();
        protected abstract void SetMovementSpeed();
        protected abstract void SetAttackSpeed();
        public abstract void Move(int direction);
    }
}
