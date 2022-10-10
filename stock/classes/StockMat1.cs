using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    public class StockMat1 : Stock
    {
        #region attributs

        public static List<StockMat1> CollClassStockMat1 = new List<StockMat1>();
        private Mat1 _laMat1; // nom de la matiere premiere - bizarre
        private int _quantite;
        private int _stockMinimum;
        #endregion

        #region constructeurs

        public StockMat1(int quantite, int stockminimum, Mat1 laMat1) : base(quantite)
        {
            this.StockMinimum = stockminimum;
            this.Quantite = quantite;
            _laMat1 = laMat1;
            StockMat1.CollClassStockMat1.Add(this);
        }

        #endregion

        #region getters - setters

        public int StockMinimum { get => _stockMinimum; set => _stockMinimum = value; }
        public int Quantite { get => _quantite; set => _quantite = value; }
        internal Mat1 LaMat1 { get => _laMat1; set => _laMat1 = value; }

        #endregion

        #region methodes
        public void acheter(int param)
        {
            this.Quantite += param;
        }
        #endregion

    }
}
