using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
namespace PenjualanHewanTernak.Model
{
    public class PosMutasiStokItem : FSBindingItem
    {
        #region Declaration
        private string noRef;
        private bool isPemasukan;
        private string keterangan;
        private bool stat;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string NoRef
        {
            get { return noRef; }
            set { noRef = value; }
        }
        public bool IsPemasukan
        {
            get { return isPemasukan; }
            set { isPemasukan = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public bool Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
