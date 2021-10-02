using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock.classes
{
    class Composant
    {
        #region attributs

        public static List<Composant> CollClassComposant = new List<Composant>();

        private string nom;
       // un composant est fabriqué à partir de plusieurs matières premieres
       // chaque matiere premiere utilisée doit etre quantifiée

        #endregion

        #region constructeurs

        public Composant(string nom)
        {
            this.nom = nom;
            

            Composant.CollClassComposant.Add(this);
        }
        #endregion

        #region getters - setters

        public string Nom { get => nom; set => nom = value; }
       
        #endregion

        #region methodes
        #endregion


    }
}
