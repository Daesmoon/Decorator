using SFML.Graphics;

namespace Decorator
{
    class RedPlayerDecorator : Decorator
    {
        public RedPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetShape();
        }

        protected override void SetMovementSpeed()
        {
            speed = 5f;
        }
        
        public override void SetShape()
        {
            //playerTexture = new Texture("Assets/Pacman.bmp");
            //playerSprite = new Sprite(playerTexture);
            //playerSprite.Position = position;

            playerShape = new RectangleShape(playerSize);
            playerShape.FillColor = Color.Red;
            playerShape.Position = position;
        }

        public override RectangleShape GetShape()
        {
            return playerShape;
        }
    }
}