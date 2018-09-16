using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;

namespace Decorator
{
    class GreenPlayerDecorator : Decorator
    {
        public GreenPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetSprite();
        }

        public override void SetSprite()
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
