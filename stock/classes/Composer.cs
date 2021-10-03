using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class Composer
    {
        /* considere qu'un composer peut etre constitué de un à plusieurs composants
         * différents. par exemple le composer 1 est composé du composant1 et du com
         * posant3
         * 
         */
        #region attributs
        public static List<Composer> CollClassComposer = new List<Composer>();

        private int _quantite; // il s'agit du nombre de composants du composer
        private List<Composant> _lesComposants; //un composant peut etre present en plusieurs exemplaires
        private Mat1 _laMat1;// Bizarre !!!!!


        #endregion

        #region constructeurs
        public Composer(int quantite, List<Composant> lesComposants, Mat1 laMat1)
        {
            Quantite = quantite;
            LesComposants = lesComposants;
            _laMat1 = laMat1;
            Composer.CollClassComposer.Add(this);
        }

        #endregion

        #region getters - setters

        public int Quantite { get => _quantite; set => _quantite = value; }
        public List<Composant> LesComposants { get => _lesComposants; set => _lesComposants = value; }
        public Mat1 LaMat1 { get => _laMat1; set => _laMat1 = value; }
        #endregion

        #region methodes


        #endregion
    }
}
