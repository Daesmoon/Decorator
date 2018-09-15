using SFML.Graphics;
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
            //shape.FillColor = Color.Green;
        }

        protected override void SetAttackSpeed()
        {
            //attackSpeed = 0.5f;
        }
    }
}
