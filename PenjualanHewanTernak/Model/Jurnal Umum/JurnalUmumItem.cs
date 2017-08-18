using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class JurnalUmumItem : FSBindingItem
    {
        #region Properties
        public int NomorTransaksi { get; }
        public DateTime TglTransaksi { get; }
        public string Reference { get; }
        public decimal Kredit { get; }
        public decimal Debit { get; }
        public string NoBukti { get; }
        public decimal Saldo { get; }
        public string Pengguna { get; }
        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion
    }
}
