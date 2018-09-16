using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class RedPlayerDecorator : Decorator
    {

        public RedPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
                   
        }

        protected override void SetMovementSpeed()
        {
            speed = 5f;
        }

        
        public override void SetSprite()
        {
            playerTexture = new Texture("Assets/PoulpiRed.bmp");
            playerSprite = new Sprite(playerTexture);
        }
        
  }
}
