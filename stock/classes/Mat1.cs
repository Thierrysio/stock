using System.Collections;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class Mat1
    {
        #region attributs

        public static List<Mat1> CollClassMat1 = new List<Mat1>();

        private string _nom;
        

        #endregion

        #region constructeurs

        public Mat1(string nom)
        {
            Nom = nom;

        }


        #endregion

        #region getters - setters

        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region methodes

        #endregion
    }
}
