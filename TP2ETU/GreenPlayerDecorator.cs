using SFML.Graphics;

namespace Decorator
{
    class GreenPlayerDecorator : Decorator
    {
        public GreenPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetShape();
        }

        public override void SetShape()
        {
            playerShape = new RectangleShape(playerSize);
            playerShape.FillColor = Color.Green;
            playerShape.Position = position;
        }

        public override RectangleShape GetShape()
        {
            return playerShape;
        }
    }
}