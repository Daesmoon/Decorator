using SFML.Graphics;

namespace Decorator
{
    class BluePlayerDecorator : Decorator
    {
        //Constructeur
        public BluePlayerDecorator(Component baseComponent) : base(baseComponent)
        {
            SetShape();
        }

        //Fonction pour ajuster la vitesse de mouvement
        protected override void SetMovementSpeed()
        {
            speed = 0.5f;
        }

        //Fonction pour ajuster la forme du joueur
        public override void SetShape()
        {
            playerShape = new RectangleShape(playerSize);
            playerShape.FillColor = Color.Blue;
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