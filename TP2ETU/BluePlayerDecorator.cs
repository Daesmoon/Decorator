using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    class BluePlayerDecorator : Decorator
    {
        public BluePlayerDecorator(Component baseComponent) : base(baseComponent)
        {

        }

        protected override void SetMovementSpeed()
        {
            speed = 0.5f;
        }

        public override void SetSprite()
        {
            //playerTexture = new Texture("Assets/PoulpiBleu.bmp"); //Trouver un sprite pour PoulpiBleu
            //playerSprite = new Sprite(playerTexture);
        }

        public override Vector2f GetPosition()
        {
            throw new System.NotImplementedException();
        }
    }
}
