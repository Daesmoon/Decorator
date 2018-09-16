﻿using System;
using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    class BasePlayer : Component
    {
        protected Texture weaponTexture;
        protected Sprite weaponSprite;
        //protected Texture playerTexture;
        //protected Sprite playerSprite;
        private RectangleShape playerShape;

        public override void Move(int direction)
        {
            
        }

        protected override void SetMovementSpeed()
        {
            throw new System.NotImplementedException();
        }

        public override void SetShape()
        {
            //playerTexture = new Texture("Assets/Pacman.bmp");
            //playerSprite = new Sprite(playerTexture);
        }

        /*public override void SetWeaponSprite()
        {
            //weaponTexture = new Texture();
            //weaponSprite = new Sprite(weaponTexture);
        }*/

        public override RectangleShape GetShape()
        {
            return playerShape;
        }

        /*public override Sprite GetSprite()
        {
            return playerSprite;
        }*/
    }
}
