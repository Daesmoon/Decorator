﻿using System;
using SFML.Graphics;
using SFML.Window;

namespace Decorator
{
    class ApplicationGame
    {
        private const int MAX_FPS = 40;
        private const string WINDOW_TITLE = "Decorator";

        private RenderWindow window = null;
        private Game game = null;
        private Keyboard.Key lastKeyPressed = Keyboard.Key.Space;

        private void OnClose(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        void OnKeyPressed(object sender, KeyEventArgs e)
        {
            lastKeyPressed = e.Code;
        }

        void OnKeyReleased(object sender, KeyEventArgs e)
        {
            lastKeyPressed = Keyboard.Key.Space;
        }

        public ApplicationGame()
        {
            window = new RenderWindow(new VideoMode(Game.GAME_WIDTH, Game.GAME_HEIGHT), WINDOW_TITLE, Styles.Titlebar);
            window.Closed += new EventHandler(OnClose);
            window.KeyPressed += new EventHandler<KeyEventArgs>(OnKeyPressed);
            window.KeyReleased += new EventHandler<KeyEventArgs>(OnKeyReleased);
            window.SetFramerateLimit(MAX_FPS);
        }
        //
        public void Run(ColorType playerColor)
        {
            game = new Game(playerColor);
            window.SetActive();

            while ((lastKeyPressed != Keyboard.Key.Escape) && window.IsOpen)
            {
                game.Update(lastKeyPressed);

                window.Clear(Color.Black);
                window.DispatchEvents();
                game.Draw(window);
                window.Display();
            }
        }
    }
}