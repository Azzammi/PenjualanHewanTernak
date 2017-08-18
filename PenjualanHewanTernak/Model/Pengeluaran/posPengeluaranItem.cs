using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class posPengeluaranItem:FSBindingItem
    {
        #region Declarations
        private string reference;
        private string keterangan;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string Ref
        {
            get { return reference; }
            set { reference = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
