using SFML.Graphics;

namespace Decorator
{
    class BluePlayerDecorator : Decorator
    {
        public BluePlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetShape();
        }

        protected override void SetMovementSpeed()
        {
            speed = 0.5f;
        }

        public override void SetShape()
        {
            playerShape = new RectangleShape(playerSize);
            playerShape.FillColor = Color.Blue;
            playerShape.Position = position;
        }

        public override RectangleShape GetShape()
        {
            return playerShape;
        }
    }
}