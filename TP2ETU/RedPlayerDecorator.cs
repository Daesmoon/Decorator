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
        //public RectangleShape playerShape = null;

        public RedPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            playerShape = new RectangleShape(new Vector2f(50, 50));
            playerShape.FillColor = Color.Red;
        }

        protected override void SetMovementSpeed()
        {
            speed = 5f;
        }
    }
}
