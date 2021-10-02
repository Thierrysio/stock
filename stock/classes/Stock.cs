using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    abstract class Stock
    {
        #region attributs
        public static List<Stock> CollClassStock = new List<Stock>();

        private int _quantite;
        

        #endregion

        #region constructeurs

        public Stock(int quantite)
        {
            Quantite = quantite;
            Stock.CollClassStock.Add(this);
        }



        #endregion

        #region getters - setters

        public int Quantite { get => _quantite; set => _quantite = value; }
        #endregion

        #region methodes
        public void AjouterAuStock()
        {
        }
        public void EnleverDuStock()
        {

        }

        #endregion
    }
}
