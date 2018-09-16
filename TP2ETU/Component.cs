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
        public abstract void SetSprite();
        public abstract void SetWeaponSprite();
        protected abstract void SetMovementSpeed();
        public abstract void Move(int direction);
        public abstract Sprite GetSprite();
    }
}
