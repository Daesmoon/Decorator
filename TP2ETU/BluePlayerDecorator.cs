using SFML.Graphics;

namespace Decorator
{
    class BluePlayerDecorator : Decorator
    {
        public BluePlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            //playerTexture = new Texture("Assets/Poulpi.bmp");
            //playerSprite = new Sprite(playerTexture);
        }

        protected override void SetMovementSpeed()
        {
            speed = 0.5f;
        }
    }
}
