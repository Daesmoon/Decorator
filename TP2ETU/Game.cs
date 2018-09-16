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

        private Component component;
        private BasePlayer basePlayer = null;
        private RedPlayerDecorator redPlayer = null;
        private BluePlayerDecorator bluePlayer = null;
        private GreenPlayerDecorator greenPlayer = null;
        //private GreenGunDecorator greenGun = null;

        private Texture backgroundTexture = new Texture("Assets/None.bmp");
        private Sprite backgroundSprite = null;

        private RectangleShape player;
        private string playerColor;

        public Game(string playerColor)
        {
            this.playerColor = playerColor;

            basePlayer = new BasePlayer();
            redPlayer = new RedPlayerDecorator(basePlayer);
            bluePlayer = new BluePlayerDecorator(basePlayer);
            greenPlayer = new GreenPlayerDecorator(basePlayer);

            /*if (playerColor == "Red")
            {
                redPlayer = new RedPlayerDecorator(basePlayer);
                component = redPlayer;
            }
            else if (playerColor == "Blue")
            {
                bluePlayer = new BluePlayerDecorator(basePlayer);
                component = bluePlayer;
            }
            else if (playerColor == "Green")
            {
                greenPlayer = new GreenPlayerDecorator(basePlayer);
                component = greenPlayer;
            }*/
            
            backgroundSprite = new Sprite(backgroundTexture);

            //player = bluePlayer.GetShape();
        }

        public void Update(Keyboard.Key key)
        {
            /*if (key == Keyboard.Key.A)
            {
                component.Move(-1);
            }
            else if (key == Keyboard.Key.D)
            {
                component.Move(1);
            }*/

            if(playerColor == "Red")
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
            else if (playerColor == "Blue")
            {
                if(key == Keyboard.Key.A)
            {
                    bluePlayer.Move(-1);
                }
            else if (key == Keyboard.Key.D)
                {
                    bluePlayer.Move(1);
                }
            }
            else if (playerColor == "Green")
            {
                if (key == Keyboard.Key.A)
                {
                    greenPlayer.Move(-1);
                }
                else if (key == Keyboard.Key.D)
                {
                    greenPlayer.Move(1);
                }
            }
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

            if (playerColor == "Red")
            {
                window.Draw(redPlayer.GetShape());
            }
            else if (playerColor == "Blue")
            {
                window.Draw(bluePlayer.GetShape());
            }
            else if (playerColor == "Green")
            {
                window.Draw(greenPlayer.GetShape());
            }
            //window.Draw(component.GetShape());
        }
    }
}