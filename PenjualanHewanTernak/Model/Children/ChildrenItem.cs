using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class ChildrenItem : FSBindingItem
    {
        #region Declarations    
        private string kodeAnak;
        private string kodeCustomer = "";
        private string nama = "";
        private string namaAyah = "";
        private string namaIbu = "";
        private string jenisKelamin = "";
        private DateTime tglLahir = DateTime.Now;
        private string tempatLahir = "";
        #endregion

        #region Cosntructor
        public ChildrenItem()
        {

        }

        public ChildrenItem(string kodeCust)
        {
            ChildrenItemDAO dao = new ChildrenItemDAO();
            dao.CreateDatabaseRecord(this, kodeCust);
        }
        #endregion

        #region Properties
        public string Kodeanak
        {
            get { return kodeAnak; }
            set { kodeAnak = value; }
        }
        public string KodeCust
        {
            get { return kodeCustomer; }
            set { kodeCustomer = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public string NamaAyah
        {
            get { return namaAyah; }
            set { namaAyah = value; }
        }
        public string NamaIbu
        {
            get { return namaIbu; }
            set { namaIbu = value; }
        }
        public string JenisKelamin
        {
            get { return jenisKelamin; }
            set { jenisKelamin = value; }
        }
        public DateTime TglLahir
        {
            get { return tglLahir; }
            set { tglLahir = value; }
        }
        public string TempatLahir
        {
            get { return tempatLahir; }
            set { tempatLahir = value; }
        }
        #endregion

        #region Methods
        internal void UpdateDatabaseRecord()
        {
            ChildrenItemDAO dao = new ChildrenItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            ChildrenItemDAO dao = new ChildrenItemDAO();
            dao.DeleteDatabaseRecord(this.Kodeanak);
        }
        #endregion
    }
}
