using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class JenisItem : FSBindingItem
    {
        #region Declarartions
        private string kodeJenis;
        private string keterangan;
        private bool stat;
        #endregion

        #region Constructor
        public JenisItem()
        {

        }
        #endregion

        #region Properties
        public string KodeJenis
        {
            get { return kodeJenis; }
            set { kodeJenis = value; }
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
            JenisItemDAO dao = new JenisItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            JenisItemDAO dao = new JenisItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            JenisItemDAO dao = new JenisItemDAO();
            dao.DeleteDatabaseRecord(this.KodeJenis);
        }
        #endregion
    }
}
