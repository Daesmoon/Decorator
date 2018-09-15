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
        protected RectangleShape playerShape = null;
        private Component baseComponent;
        private BasePlayer basePlayer = null;
        private RedPlayerDecorator redPlayer = null;
        
        //protected Texture weaponTexture = new Texture("Assets/Poulpi.bmp"); //TODO: changer
        //protected Sprite weaponSprite = null;
        protected float speed;
        //protected CircleShape shape = new CircleShape(50);
        //protected float attackSpeed;

        private Vector2f position = new Vector2f(200, 200);
        //private Vector2f projectilePosition = new Vector2f();

        protected Decorator(Component baseComponent)
        {
            this.baseComponent = baseComponent;

            //player = new RectangleShape();
            //playerShape = new RedPlayerDecorator(baseComponent);
            basePlayer = new BasePlayer();
            redPlayer = new RedPlayerDecorator(basePlayer);
        } 

        public override void SetSprite()
        {
            //playerSprite = new Sprite(playerTexture);
            //playerSprite = new Sprite(playerTexture);
            //playerSprite.Origin = new Vector2f(playerTexture.Size.X / 2, playerTexture.Size.Y / 2);
            //position = new Vector2f(Game.GAME_WIDTH / 2, Game.GAME_HEIGHT - playerTexture.Size.Y);
            
        }

        public override void SetWeapon()
        {
            //weaponSprite = new Sprite(weaponTexture);
        }

        public override void Move(int direction)
        {
            /*if (direction > 0)
            {
                playerSprite.TextureRect(IntRect(0, 0, playerTexture.Size.X, -playerTexture.Size.Y));
                playerSprite.Scale(-1, 1);
            }*/

            position.X = position.X + direction * speed;
        }

        public void Shoot()
        {
            //projectilePosition = new Vector2f(position.X - (playerTexture.Size.X / 2), position.Y);
            //projectilePosition
        }

        public void Draw(RenderWindow window)
        {
            redPlayer.playerShape.Position = position;
            window.Draw(redPlayer.playerShape);
        }

        protected override void SetMovementSpeed()
        {
            speed = 1;
        }

        protected override void SetAttackSpeed()
        {
            //attackSpeed = 1;
        }
    }
}
