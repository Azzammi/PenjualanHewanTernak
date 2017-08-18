using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class KandangItem: FSBindingItem
    {
        #region Declarations
        private string kodeKandang;
        private string keterangan;
        private bool stat;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string KodeKandang
        {
            get { return kodeKandang; }
            set { kodeKandang = value; }
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
        internal void CreateDatabaseRecord()
        {
            KandangItemDAO dao = new KandangItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            KandangItemDAO dao = new KandangItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            KandangItemDAO dao = new KandangItemDAO();
            dao.DeleteDatabaseRecord(this.KodeKandang);
        }
        #endregion
    }
}

