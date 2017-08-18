using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class StockItem : FSBindingItem
    {
        #region Declarations
        private string kodeGudang;
        private string kodeHewan;
        private string keterangan;
        private int stok;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string KodeGudang
        {
            get { return kodeGudang; }
            set { kodeGudang = value; }
        }
        public string KodeHewan
        {
            get { return kodeHewan; }
            set { kodeHewan = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public int Stok
        {
            get { return stok; }
            set { stok = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
