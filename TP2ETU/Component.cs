using SFML.Graphics;

namespace Decorator
{
    //Classe abstraite qui contient toutes les méthodes qui devront être implémenter par la classe Decorator
    public abstract class Component
    {
        public abstract void SetShape();
        protected abstract void SetMovementSpeed();
        public abstract void Move(int direction);
        public abstract RectangleShape GetShape();
    }
}