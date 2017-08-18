using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class InfaqItem : FSBindingItem
    {
        #region Declarations
        private string kodeInfaq;
        private string keterangan;
        private bool isPercent;
        private decimal nilai;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string KodeInfaq
        {
            get { return kodeInfaq; }
            set { kodeInfaq = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public bool IsPercent
        {
            get { return isPercent; }
            set { isPercent = value; }
        }
        public decimal Nilai
        {
            get { return nilai; }
            set { nilai = value; }
        }
        #endregion

        #region Methods

        #endregion
    }
}
