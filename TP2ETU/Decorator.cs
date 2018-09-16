using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    public abstract class Decorator : Component
    {
        private Component baseComponent;
        protected Texture weaponTexture;
        protected Sprite weaponSprite;
        protected Texture playerTexture;
        protected Sprite playerSprite;
        protected Vector2f position;
        protected float speed = 5;

        protected Decorator(Component baseComponent)
        {
            this.baseComponent = baseComponent;
        } 

        public override void SetSprite()
        {
            playerTexture = new Texture("Assets/Poulpi.bmp");
            playerSprite = new Sprite(playerTexture);
            playerSprite.Origin = new Vector2f(playerTexture.Size.X / 2, playerTexture.Size.Y / 2);
            position = new Vector2f(Game.GAME_WIDTH / 2, Game.GAME_HEIGHT - playerTexture.Size.Y);            
        }

        public override void SetWeaponSprite()
        {
            //weaponTexture = new Texture("Assets/Weapon.bmp"); //Trouver un sprite pour le Weapon
            //weaponSprite = new Sprite(weaponTexture);
        }

        public override void Move(int direction)
        {
            position.X = position.X + direction * speed;

            playerSprite.Position = position;
            playerSprite.Transform.Translate(position);
        }

        protected override void SetMovementSpeed()
        {
            speed = 2f;
        }

        public override Sprite GetSprite()
        {
            return playerSprite;
        }
    }
}
