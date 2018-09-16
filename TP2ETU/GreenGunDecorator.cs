using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class GreenGunDecorator : Decorator
    {
        public GreenGunDecorator(Component baseComponent) : base(baseComponent)
        {

        }

        public override void Draw(RenderWindow window)
        {
            throw new NotImplementedException();
        }

        public override Vector2f GetPosition()
        {
            throw new NotImplementedException();
        }

        public override void SetWeaponSprite()
        {
            weaponTexture = new Texture("Assets/GreenWeapon.bmp"); //Trouver sprite pour weapon vert
            weaponSprite = new Sprite(weaponTexture);
        }
  }
}
