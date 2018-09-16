using SFML.Graphics;

namespace Decorator
{
    class GreenPlayerDecorator : Decorator
    {
        //Constructeur
        public GreenPlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetShape();
        }

        //Fonction pour ajuster la forme du joueur
        public override void SetShape()
        {
            playerShape = new RectangleShape(playerSize);
            playerShape.FillColor = Color.Green;
            playerShape.Position = position;
        }

        //Fonction pour obtenir la forme du joueur
        //retour: un RectangleShape correspondant à la forme du joueur
        public override RectangleShape GetShape()
        {
            return playerShape;
        }
    }
}