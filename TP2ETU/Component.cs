using SFML.Graphics;
using SFML.System;
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
        public abstract Vector2f GetPosition();
        public abstract void Draw(RenderWindow window);
    }
}
