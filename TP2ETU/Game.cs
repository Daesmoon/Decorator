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

        private Texture backgroundTexture = new Texture("Assets/None.bmp");
        private Sprite backgroundSprite = null;

        private RectangleShape player;
        private ColorType playerColor;

        //Constructeur
        public Game(ColorType playerColor)
        {
            this.playerColor = playerColor;

            basePlayer = new BasePlayer();
            redPlayer = new RedPlayerDecorator(basePlayer);
            bluePlayer = new BluePlayerDecorator(basePlayer);
            greenPlayer = new GreenPlayerDecorator(basePlayer);         
            backgroundSprite = new Sprite(backgroundTexture);
        }

        //Méthode de mise à jour du joueur
        public void Update(Keyboard.Key key)
        {
            switch (this.playerColor)
            {
              case ColorType.Red:
              if (key == Keyboard.Key.A)
              {
                redPlayer.Move(-1);
              }
              else if (key == Keyboard.Key.D)
              {
                redPlayer.Move(1);
              }
              break;
                      
              case ColorType.Blue:
              if (key == Keyboard.Key.A)
              {
                bluePlayer.Move(-1);
              }
              else if (key == Keyboard.Key.D)
              {
                bluePlayer.Move(1);
              }
              break;

              case ColorType.Green:
              if (key == Keyboard.Key.A)
              {
                greenPlayer.Move(-1);
              }
              else if (key == Keyboard.Key.D)
              {
                greenPlayer.Move(1);
              }
              break;
            }
        }

        //Méthode pour dessiner le joueur
        //paramètre: la fenêtre dans laquel on dessine le joueur
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

            switch(this.playerColor)
            {
              case ColorType.Red:
              window.Draw(redPlayer.GetShape());
              break;

              case ColorType.Blue:
              window.Draw(bluePlayer.GetShape());
              break;

              case ColorType.Green:
              window.Draw(greenPlayer.GetShape());
              break;
            }         
        }
    }
}