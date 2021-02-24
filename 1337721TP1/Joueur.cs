using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Joueur
    {
        public Joueur(CouleurPion couleur)
        {
            _couleur = couleur;
            _nbPoints = NbPointsInitial;

            Console.Write("Joueur {0} : Veuillez entrer votre nom : ", couleur);
            _nom = Console.ReadLine().Trim();

            while (_nom.Length == 0)
            {
                Console.Write("Joueur {0} : Le nom entré est vide. Veuillez entre un nom valide : ", couleur);
                _nom = Console.ReadLine().Trim();
            }
        }
        public void AjouterPoints(int nbPoint)
        {
            _nbPoints += nbPoint;
        }
        public void EnleverPoints(int nbPoint)
        {
            if (nbPoint <= Points)
            {
                _nbPoints -= nbPoint;
            }
        }
        public bool EstGagnant()
        {
            if (_nbPoints == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Points
        {
            get { return _nbPoints; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public CouleurPion Couleur
        {
            get { return _couleur; }
        }

        public readonly string _nom;
        private int _nbPoints;
        public readonly CouleurPion _couleur;
        public const int NbPointsInitial = 167;

    }

}