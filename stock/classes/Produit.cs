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

        public int getListeMatierePremieres()
        {
            int resultat = 0;

            return resultat;
            #endregion
        }
    }
}
