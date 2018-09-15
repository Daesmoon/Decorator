using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    class BasePlayer : Component
    {
        //public RectangleShape playerShape = null;

        public BasePlayer()
        {
            //playerShape = new RectangleShape(new Vector2f(50, 50));
            //playerShape.FillColor = Color.Black;
        }

        public override void Move(int direction)
        {
            throw new System.NotImplementedException();
        }

        protected override void SetMovementSpeed()
        {
            throw new System.NotImplementedException();
        }

        public override void SetSprite()
        {
           //playerTexture = new Texture("Assets/Poulpi.bmp");
            //playerSprite = new Sprite(playerTexture);
        }

        public override void SetWeapon()
        {
            //weaponTexture = texture;
            //weaponSprite = new Sprite(weaponTexture);
        }

        protected override void SetAttackSpeed()
        {
            throw new System.NotImplementedException();
        }
    }
}
