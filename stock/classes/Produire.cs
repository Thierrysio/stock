using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class Produire
    {

        //nous pensons que cette classe ne doit pas etre implémentée.
        #region attributs

        private int _quantite;
        private Produit _leProduit;
        


        #endregion

        #region constructeurs

        public Produire(int quantite, Produit leProduit)
        {
            Quantite = quantite;
            LeProduit = leProduit;
            

        }


        #endregion

        #region getters - setters

        public int Quantite { get => _quantite; set => _quantite = value; }
        public Produit LeProduit { get => _leProduit; set => _leProduit = value; }


        #endregion

        #region methodes

        #endregion
    }
}
