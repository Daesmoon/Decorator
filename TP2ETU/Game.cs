﻿using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Decorator
{
    public class Game
    {
        public const int GAME_WIDTH = 600;
        public const int GAME_HEIGHT = 400;
        private const int BACKGROUND_TILE_DIMENSION = 20;

        private BasePlayer player = null;
        private RedPlayerDecorator redPlayer = null;
        private BluePlayerDecorator bluePlayer = null;
        private GreenGunDecorator greenGun = null;

        private Texture backgroundTexture = new Texture("Assets/None.bmp");
        private Sprite backgroundSprite = null;

        public Game()
        {
            player = new BasePlayer();
            redPlayer = new RedPlayerDecorator(player);
            backgroundSprite = new Sprite(backgroundTexture);
        }

        public void Update(Keyboard.Key key)
        {
            if (key == Keyboard.Key.A)
            {
                redPlayer.Move(-1);
            }
            else if (key == Keyboard.Key.D)
            {
                redPlayer.Move(1);
            }

            redPlayer.GetSprite().Position = redPlayer.GetPosition();
        }

        public void Draw(RenderWindow window)
        {
            for (int row = 0; row < (GAME_HEIGHT / BACKGROUND_TILE_DIMENSION); row++)
            {
                for (int col = 0; col < (GAME_WIDTH / BACKGROUND_TILE_DIMENSION); col++)
                {
                    backgroundSprite.Position = new Vector2f(col * (GAME_WIDTH / BACKGROUND_TILE_DIMENSION), row * (GAME_HEIGHT / BACKGROUND_TILE_DIMENSION));
                    window.Draw(backgroundSprite);
                }
            }

            
            window.Draw(redPlayer.GetSprite());              
        }
    }
}
