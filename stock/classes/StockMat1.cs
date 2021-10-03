using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class StockMat1 : Stock
    {
        #region attributs

        public static List<StockMat1> CollClassStockMat1 = new List<StockMat1>();
        private string _nom; // nom de la matiere premiere - bizarre
        private int _quantite;
        private int _stockMinimum;
        #endregion

        #region constructeurs

        public StockMat1(int quantite, int stockminimum) : base(quantite)
        {
            this.StockMinimum = stockminimum;
            this.Quantite = quantite;
        }

        #endregion

        #region getters - setters

        public int StockMinimum { get => _stockMinimum; set => _stockMinimum = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }

        #endregion

        #region methodes
        public void acheter()
        {

        }
        #endregion

    }
}
