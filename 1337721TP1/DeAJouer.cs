using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class DeAJouer
    {
        /// <summary>
        /// Constructeur d'un dé à jouer
        /// </summary>
        public DeAJouer()
        {
            _jouable = false;
        }
        public void Lancer()
        {
            _jouable = true;
            _valeurDe = Valeur;
        }
        public void Dupliquer(DeAJouer deADupliquer)
        {
            _jouable = deADupliquer._jouable;
            _valeurDe = deADupliquer._valeurDe;
        }
        public void Jouer()
        {
            _jouable = false;
        }
        public int Valeur
        {
            get { return GenererNombreAleatoire(); }

        }
        public bool EstJouable
        {
            get { return _jouable; }
        }
        private int GenererNombreAleatoire()
        {
            Random generateurAleatoire = new Random();
            //La valeur minimal sera générée, mais pas la valeur maximale
            //Code provient des labos fait en classe
            return (generateurAleatoire.Next(1, 7));
        }

        private bool _jouable;
        //private bool _lancer = false;
        private int _valeurDe; //Représente la valeur du dé.

    }
}
