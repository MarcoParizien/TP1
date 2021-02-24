using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    /// <summary>
    /// Identification des types de pions
    /// </summary>
    enum CouleurPion
    {
        Blanc,
        Rouge
    }

    class Pion
    {
        /// <summary>
        /// Constructeur des pions
        /// </summary>
        /// <param name="couleur">Couleur du pion</param>
        public Pion(CouleurPion couleur)
        {
            _couleur = couleur;
        }
        /// <summary>
        /// Vérification que les couleurs sont différentes à la création des pions
        /// </summary>
        /// <param name="autrePion">Représente l'autre pion. Pour le comparé avec le pion créé</param>
        /// <returns></returns>
        public bool EstDeMemeCouleurQue(Pion autrePion)
        {
            if (_couleur == autrePion._couleur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public readonly CouleurPion _couleur;
    }
}