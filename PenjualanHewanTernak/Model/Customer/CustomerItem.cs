using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class CustomerItem : FSBindingItem
    {
        #region Declarations
        private ChildrenList p_List;
        private string kodeCust;
        private string namaCust = "";
        private string alamatCust = "";
        private string emailCust = "";
        private string telpCust = "";
        private DateTime tglMasuk = DateTime.Now;
        private bool isDiscount ;
        private bool isPercent ;
        private double diskon;
        private string keterangan = "";
        #endregion

        #region Constructor
        public CustomerItem() { }

        public CustomerItem(bool CreateDatabaseRecord)
        {
            p_List = new ChildrenList();

            if(CreateDatabaseRecord == true)
            {
                CustomerItemDAO dao = new CustomerItemDAO();
                dao.CreateDatabaseRecord(this);
            }
        }
        #endregion

        #region Properties
        public ChildrenList Items
        {
            get { return p_List; }
            set { p_List = value; }
        }
        public string KodeCust
        {
            get { return kodeCust; }
            set { kodeCust = value; }
        }
        public string NamaCust
        {
            get { return namaCust; }
            set { namaCust = value; }
        }
        public string Alamat
        {
            get { return alamatCust; }
            set { alamatCust = value; }
        }
        public string Email
        {
            get { return emailCust; }
            set { emailCust = value; }
        }
        public string Telepon
        {
            get { return telpCust; }
            set { telpCust = value; }
        }
        public DateTime TglMasuk
        {
            get { return tglMasuk; }
            set { tglMasuk = value; }
        }
        public bool IsDiscount
        {
            get { return isDiscount; }
            set { isDiscount = value; }
        }
        public bool IsPercent
        {
            get { return isPercent; }
            set { isPercent = value; }
        }
        public double Diskon
        {
            get { return diskon; }
            set { diskon = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        #endregion

        #region Methods
        internal void DeleteItem()
        {
            p_List.ClearAll();
        }
        internal void CreateDatabaseRecord()
        {
            CustomerItemDAO dao = new CustomerItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            CustomerItemDAO dao = new CustomerItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            CustomerItemDAO dao = new CustomerItemDAO();
            dao.DeleteDatabaseRecord(this.KodeCust);
        }
        #endregion
    }
}
