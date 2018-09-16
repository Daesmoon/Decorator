using System;
using SFML.Graphics;
using SFML.System;

namespace Decorator
{
    class BasePlayer : Component
    {
        protected Texture weaponTexture;
        protected Sprite weaponSprite;
        private RectangleShape playerShape;

        //Fonction de déplacement
        //paramètre: un entier représentant la direction du mouvement
        public override void Move(int direction)
        {  
                
        }

        //Fonction pour ajuster la vitesse de mouvement
        protected override void SetMovementSpeed()
        {
            throw new System.NotImplementedException();
        }

        //Fonction pour ajuster la forme du joueur
        public override void SetShape()
        {

        }

        //Fonction pour obtenir la forme du joueur
        //retour: un RectangleShape correspondant à la forme du joueur
        public override RectangleShape GetShape()
        {
            return playerShape;
        }
    }
}
