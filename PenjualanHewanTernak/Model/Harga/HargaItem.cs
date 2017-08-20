using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class HargaItem : FSBindingItem
    {
        #region Declarations
        private string kodeHewan;
        private string kodeGrade;
        private DateTime beforePriceDate;
        private decimal beforePrice;
        private DateTime currentPriceDate;
        private decimal currentPrice;
        private bool stat;
        #endregion

        #region Constructor

        #endregion

        #region Properties
        public string KodeHewan
        {
            get { return kodeHewan; }
            set { kodeHewan = value; }
        }
        public string KodeGrade
        {
            get { return kodeGrade; }
            set { kodeGrade = value; }
        }
        public DateTime BeforePriceDate
        {
            get
            {
                return beforePriceDate;
            }
            set
            {
                beforePriceDate = value;     
            }
        }
        public decimal BeforePrice
        {
            get { return beforePrice; }
            set { beforePrice = value; }
        }
        public DateTime CurrentPriceDate
        {
            get
            {
                return currentPriceDate;
            }
            set { currentPriceDate = value; }
        }
        public decimal CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
        public bool Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        #endregion

        #region Methods
        //Methods to change current Price
        internal void GantiHarga()
        {
            HargaItemDAO dao = new HargaItemDAO();
            dao.UbahHarga(this);
        }

        internal void CreateDatabaseRecord()
        {
            HargaItemDAO dao = new HargaItemDAO();
            dao.CreateDatabaseRecord(this);
        }

        internal void UpdateDatabaseRecord()
        {
            HargaItemDAO dao = new HargaItemDAO();
            dao.UpdateDatabaseRecord(this);
        }

        internal void DeleteDatabaseRecord()
        {
            HargaItemDAO dao = new HargaItemDAO();
            dao.DeleteDatabaseRecord(this.KodeGrade, this.KodeHewan);
        }
        #endregion
    }
}
