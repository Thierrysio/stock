using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class Produit
    {
        /* considere qu'un produit peut etre constitué de un à plusieurs composer
         * différents. par exemple le produit 1 est composé du composer1 et du com
         * poser3
         * 
         */

        #region attributs
        public static List<Produit> CollClassProduit = new List<Produit>();

        private string nom;
        private List<Composer> _lesComposer;
        

        #endregion

        #region constructeurs

        public Produit(string nom)
        {
            this.nom = nom;
            _lesComposer = new List<Composer>();

            Produit.CollClassProduit.Add(this);
        }

        #endregion

        #region getters - setters

        
        public List<Composer> LesComposer { get => _lesComposer; set => _lesComposer = value; }


        #endregion

        #region methodes

        public List<Mat1> getListeMatierePremieresNecessaires()
        {
            List<Mat1> resultat = new List<Mat1>();

            return resultat;
            #endregion
        }
    }
}
