using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    public class Composant
    {
        #region attributs

        public static List<Composant> CollClassComposant = new List<Composant>();

        private string nom;
        // un composant est fabriqué à partir de plusieurs matières premieres
        //                       implementer l'attribut
        private Dictionary<Mat1,int> _dicoMat1;
        #endregion

        #region constructeurs

        public Composant(string nom)
        {
            this.nom = nom;
            this.LesMat1 = new DictionaryBase<Mat1,int>();

            Composant.CollClassComposant.Add(this);
        }
        #endregion

        #region getters - setters

        public string Nom { get => nom; set => nom = value; }
        public Dictionary<Mat1,int> DicoMat1 { get => _dicoMat1; set => _dicoMat1 = value; }

        #endregion

        #region methodes
        public Dictionary<Mat1, int> GetMatieres()
        {
     
            return this.DicoMat1;

        }
        #endregion


    }
}
