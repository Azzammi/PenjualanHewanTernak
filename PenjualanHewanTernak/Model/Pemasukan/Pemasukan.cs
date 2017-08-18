using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class Pemasukan : FSBindingItem
    {
        #region Declarations
        private string kodePemasukan;
        private DateTime tanggal;
        private string noBukti;
        private string keterangan;
        private decimal nominal;
        private string pengguna;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string KodePemasukan
        {
            get { return kodePemasukan; }
            set { kodePemasukan = value; }
        }
        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }
        public string NoBukti
        {
            get { return noBukti; }
            set { noBukti = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public decimal Nominal
        {
            get { return nominal; }
            set { nominal = value; }
        }
        public string Pengguna
        {
            get { return pengguna; }
            set { pengguna = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
