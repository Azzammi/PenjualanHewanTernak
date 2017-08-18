using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class CattleItem : FSBindingItem
    {
        #region Declarations
        //Member Variables
        private string kodeHewan;
        private string namaHewan;
        private string kodeGrade;
        private string kodeJenis;
        private string sort;
        private int berat;
        private string jenisKelamin;
        #endregion

        #region Constructor
        public CattleItem()
        {

        }

        //For adding new record
        public CattleItem(bool isNewRecord)
        {

        }
        #endregion

        #region Properties
        public string KodeHewan
        {
            get { return kodeHewan; }
            set { kodeHewan = value; }
        }
        public string NamaHewan
        {
            get { return namaHewan; }
            set { namaHewan = value; }
        }
        public string KodeGrade
        {
            get { return kodeGrade; }
            set { kodeGrade = value; }
        }
        public string KodeJenis
        {
            get { return kodeJenis; }
            set { kodeJenis = value; }
        }
        public string Sort
        {
            get { return sort; }
            set { sort = value; }
        }
        public int Berat
        {
            get { return berat; }
            set { berat = value; }
        }
        public string JenisKelamain
        {
            get { return jenisKelamin; }
            set { jenisKelamin = value; }
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
        {
            CattleItemDAO dao = new CattleItemDAO();
            dao.CreateDatabaseRecord(this);
        }

        internal void UpdateDatabaseRecord()
        {
            CattleItemDAO dao = new CattleItemDAO();
            dao.UpdateDatabaseRecord(this);
        }

        internal void DeleteDatabaseRecord()
        {
            CattleItemDAO dao = new CattleItemDAO();
            dao.DeleteDatabaseRecord(this.KodeHewan);
        }
        #endregion
    }
}
