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
            SetSprite();
        }

        protected override void SetMovementSpeed()
        {
            speed = 5f;
        }
        
        public override void SetSprite()
        {
            playerTexture = new Texture("Assets/Pacman2.bmp");
            playerSprite = new Sprite(playerTexture);
            playerSprite.Position = position;
        }

        public override Vector2f GetPosition()
        {
            return position;
        }

        public override void Draw(RenderWindow window)
        {
            window.Draw(playerSprite);
        }
    }
}