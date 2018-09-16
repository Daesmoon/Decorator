using SFML.Graphics;

namespace Decorator
{
    public abstract class Component
    {
        public abstract void SetShape();
        //public abstract void SetWeaponSprite();
        protected abstract void SetMovementSpeed();
        public abstract void Move(int direction);
        public abstract RectangleShape GetShape();
    }
}