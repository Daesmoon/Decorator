using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    public abstract class Decorator : Component
    {
        private Component baseComponent;
        protected Vector2f position;
        protected float speed;
        protected Vector2f playerSize = new Vector2f(50, 50);
        protected RectangleShape playerShape;


        protected Decorator(Component baseComponent)
        {
            this.baseComponent = baseComponent;
            position = new Vector2f(Game.GAME_WIDTH / 2, Game.GAME_HEIGHT - 50);
            speed = 5;
        } 

        public override void SetShape()
        {
            playerShape = new RectangleShape(new Vector2f(50, 50));
        }

        /*public override void SetWeaponSprite()
        {
            //weaponTexture = new Texture("Assets/Weapon.bmp"); //Trouver un sprite pour le Weapon
            //weaponSprite = new Sprite(weaponTexture);
        }*/

        public override void Move(int direction)
        {
            position.X = position.X + direction * speed;
            playerShape.Position = position;

        }

        protected override void SetMovementSpeed()
        {
            speed = 2f;
        }
    }
}