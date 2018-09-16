using SFML.Graphics;
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

        private Texture backgroundTexture = new Texture("Assets/Wall.bmp");
        private Sprite backgroundSprite = null;

        public Game()
        {
            player = new BasePlayer();
            redPlayer = new RedPlayerDecorator(player);
            backgroundSprite = new Sprite(backgroundTexture);

            redPlayer.GetSprite().Position = new Vector2f(GAME_WIDTH / 2, GAME_HEIGHT / 2); //probleme avec les sprites
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
        }

        public void Draw(RenderWindow window)
        {
            for (int row = 0; row < (GAME_HEIGHT / BACKGROUND_TILE_DIMENSION); row++)
            {
                for (int col = 0; col < (GAME_WIDTH / BACKGROUND_TILE_DIMENSION); col++)
                {
                    backgroundSprite.Position = new Vector2f(col * 20, row * 20);
                    window.Draw(backgroundSprite);
                }
            }

            window.Draw(redPlayer.GetSprite());              
        }
    }
}
