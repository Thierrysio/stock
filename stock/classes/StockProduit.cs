using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class StockProduit : Stock
    {
        #region attributs
        public static List<StockProduit> CollClassStockProduit = new List<StockProduit>();
        Produit _leProduit;
        //je pense que c'est dans cette classe qu'il faut implementer produire
        
        #endregion

        
        #region constructeurs

        public StockProduit(Produit leProduit, int quantite) : base(quantite)
        {
            _leProduit = leProduit;
            StockProduit.CollClassStockProduit.Add(this);
        }


        #endregion

        #region getters - setters
        public Produit LeProduit { get => _leProduit; set => _leProduit = value; }

        #endregion

        #region methodes
        public void produire()
        {
            //lorsque l'on decide de produire un produit
            // il faut verifier l'etat du stock de ce produit

            //Verifier l'etat des stocks des matieres
            //premieres necessaires à la fabrication des composants
            //qui composent les composer qui eux memes entrent dans
            //la fabrication du produit

            //si suffisant produire, enlever la quantité à produire,enlever du stock de matieres premieres et ajouter au stock de produits

            //si insuffisant acheter les matieres premieres necessaires les ajouter au stock de matieres premieres
            //produire, enlever la quantité à produire,enlever du stock de matieres premieres et ajouter au stock de produits
        }

        #endregion

    }
}
