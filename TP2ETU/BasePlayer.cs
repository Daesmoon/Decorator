using System;
using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    class BasePlayer : Component
    {
        protected Texture weaponTexture;
        protected Sprite weaponSprite;
        protected Texture playerTexture;
        protected Sprite playerSprite;

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
            playerTexture = new Texture("Assets/Poulpi.bmp");
            playerSprite = new Sprite(playerTexture);
        }

        public override void SetWeaponSprite()
        {
            //weaponTexture = new Texture();
            //weaponSprite = new Sprite(weaponTexture);
        }

        public override Sprite GetSprite()
        {
            return playerSprite;
        }
  }
}
