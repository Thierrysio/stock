using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    public class Composer
    {
        /* considere qu'un composer peut etre constitué de un à plusieurs composants
         * différents. par exemple le composer 1 est composé du composant1 et du com
         * posant3
         * 
         */
        #region attributs
        public static List<Composer> CollClassComposer = new List<Composer>();

        private Dictionary<Composant, int> _dicoComposants;

        #endregion

        #region constructeurs
        public Composer( )
        {
           
            Composer.CollClassComposer.Add(this);
            this.DicoComposants = new Dictionary<Composant, int>();
        }


        #endregion

        #region getters - setters
        public Dictionary<Composant, int> DicoComposants { get => _dicoComposants; set => _dicoComposants = value; }

        #endregion

        #region methodes
        public Dictionary<Mat1, int> GetMatieres()
        {
            Dictionary<Mat1, int> resultat = new Dictionary<Mat1, int>();

            foreach(var leComposant in this.DicoComposants )
            {
                foreach(var leMat1 in leComposant.Key.GetMatieres())
                {
                    if (resultat.ContainsKey(leMat1.Key))
                    {
                        resultat[leMat1.Key] += leMat1.Value * leComposant.Value;
                    }
                    else
                    {
                        resultat.Add(leMat1.Key, leMat1.Value * leComposant.Value);
                    }
                }
            }

            return resultat;

        }

        #endregion
    }
}
