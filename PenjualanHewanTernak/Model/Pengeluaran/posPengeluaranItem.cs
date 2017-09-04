using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class posPengeluaranItem:FSBindingItem
    {
        #region Declarations
        private string reference;
        private string keterangan;
        private bool stat;
        #endregion

        #region Constructor
        public posPengeluaranItem()
        {

        }
        public posPengeluaranItem(bool CreateDatabaseRecord)
        {
            if(CreateDatabaseRecord != false)
            {
                this.CreateDatabaseRecord();
            }
        }
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
        public bool Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
        {
            PosPengeluaranItemDAO dao = new PosPengeluaranItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            PosPengeluaranItemDAO dao = new PosPengeluaranItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            PosPengeluaranItemDAO dao = new PosPengeluaranItemDAO();
            dao.DeleteDatabaseRecord(this.Ref);
        }
        #endregion
    }
}
