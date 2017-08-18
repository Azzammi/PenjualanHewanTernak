using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class GradeItem : FSBindingItem
    {
        #region Declarations
        private string kodeGrade;
        private string keterangan;
        private bool stat;
        #endregion

        #region Declarations
        public GradeItem()
        {

        }
        #endregion

        #region Properties
        public string KodeGrade
        {
            get { return kodeGrade; }
            set { kodeGrade = value; }
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
            GradeItemDAO dao = new GradeItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            GradeItemDAO dao = new GradeItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            GradeItemDAO dao = new GradeItemDAO();
            dao.DeleteDatabaseRecord(this.KodeGrade);
        }
        #endregion
    }
}
