using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteurCalories
{
    #region Classe Aliment
    internal class Aliment
    {

            #region propriete 
            private string name;
            private Single qteLipide;
            private Single qteGlucide;
            private Single qteProteine;
            #endregion
            #region constructeurs
            public Aliment() { }
            public Aliment(string name, float qteLipide, float qteGlucide, float qteProteine)
            {
                this.name = name;
                this.qteLipide = qteLipide;
                this.qteGlucide = qteGlucide;
                this.qteProteine = qteProteine;
            }
            #endregion
            #region getters et setters
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Single QteLipide
            {
                get { return qteLipide; }
                set { qteLipide = value; }
            }
            public Single QteGlucide
            {
                get { return qteGlucide; }
                set { qteGlucide = value; }
            }
            public Single QteProteine
            {
                get { return qteProteine; }
                set { qteProteine = value; }
            }
            #endregion
    }
    #endregion
}





