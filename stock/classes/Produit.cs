using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    public class Produit
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
            this.Nom = nom;
            this.LesComposer = new List<Composer>();

            Produit.CollClassProduit.Add(this);
        }

        #endregion

        #region getters - setters

        
        public List<Composer> LesComposer { get => _lesComposer; set => _lesComposer = value; }
        public string Nom { get => nom; set => nom = value; }


        #endregion

        #region methodes

        public Dictionary<Mat1, int> GetMatieres()
        {
            Dictionary<Mat1, int> resultat = new Dictionary<Mat1, int>();

            foreach (var leComposer in this.DicoComposer)
            {
                foreach (var leMat1 in leComposer.Key.GetMatieres())
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

        public Dictionary<Mat1, int> GetAcheter()
        {
            Dictionary<Mat1, int> resultat = new Dictionary<Mat1, int>();
            foreach(var laMat1 in this.GetMatieres())
            {
                foreach(StockMat1 leStockMat1 in StockMat1.CollClassStockMat1)
                {
                    if (laMat1.Key == leStockMat1.LaMat1)
                    {
                        if (laMat1.Value < leStockMat1.Quantite)
                        {
                            leStockMat1.acheter(laMat1.Value);
                            resultat.Add(laMat1.Key, laMat1.Value);
                        }
                    }
                }

            }
            return resultat;

        }
        #endregion
    }
}
