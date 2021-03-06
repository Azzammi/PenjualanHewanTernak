﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class MutasiStokItem : FSBindingItem
    {
        #region Declarations
        private int nomorTransaksi;
        private string noRef;
        private DateTime tglTransaksi = DateTime.Now;
        private string kodeKandang;
        private string kodeHewan;
        private string keterangan;
        private int stockAwal;
        private int masuk;
        private int keluar;
        #endregion

        #region Constructor
        public MutasiStokItem()
        {

        }

        public MutasiStokItem(bool createDatabaseRecord)
        {
            if(createDatabaseRecord != false)
            {
                CreateDatabaseRecord();
            }
        }
        #endregion

        #region Properties
        public int NomorTransaksi
        {
            get { return nomorTransaksi; }
            set { nomorTransaksi = value; }
        }
        public string NoRef
        {
            get { return noRef; }
            set { noRef = value; }
        }
        public DateTime TglTransaksi
        {
            get { return tglTransaksi; }
            set { tglTransaksi = value; }
        }
        public string KodeKandang
        {
            get { return kodeKandang; }
            set { kodeKandang = value; }
        }
        public string KodeHewan
        {
            get { return kodeHewan; }
            set { kodeHewan = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public int StokAwal
        {
            get { return stockAwal; }
            set { stockAwal = value; }
        }
        public int Masuk
        {
            get { return masuk; }
            set { masuk = value; }
        }
        public int Keluar
        {
            get { return keluar; }
            set { keluar = value; }
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord()
        {
            MutasiStokDAO dao = new MutasiStokDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord(bool isDecrementStock)
        {
            MutasiStokDAO dao = new MutasiStokDAO();
            dao.UpdateDatabaseRecord(this, isDecrementStock);
        }
        internal void DeleteDatabaseRecord()
        {
            MutasiStokDAO dao = new MutasiStokDAO();
            dao.DeleteDatabaseRecord(this.NomorTransaksi);
        }
        #endregion
    }
}
