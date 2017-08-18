using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class CustomerListDAO
    {
        #region Declarations
        private bool isBindingComplete = false;
        #endregion

        #region Constructor
        public CustomerListDAO()
        {

        }
        #endregion

        #region Properties
        public bool IsBindingComplete
        {
            get { return isBindingComplete; }
            set { isBindingComplete = value; }
        }
        #endregion

        #region Methods
        public void ShowList(CustomerList customerList)
        {
            //Builds query to get Customer's and their Children
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append(string.Format("SELECT [KodeCust],[NamaCust],[Alamat],[Email],[Telp],[Tgl_Masuk],[Spesial_Diskon],[isPercent],[Diskon],[Ket] FROM [SysTernakDB].[dbo].[CUSTOMER]; "));
            sqlQuery.Append(string.Format("SELECT [KodeAnak],[KodeCust],[Nama],[NamaAyah],[NamaIbu],[JenisKelamin],[TglLahir],[TempatLahir] FROM [CHILDREN]"));

            //Get a DataSet from the query
            DataSet dataSet = DataProvider.GetDataSet(sqlQuery.ToString());

            //Create Variables for data set tables
            DataTable customerTable = dataSet.Tables[0];
            DataTable childrenTable = dataSet.Tables[1];

            //Create a data relation from Customer to Children
            DataColumn parentColumn = customerTable.Columns["KodeCust"];
            DataColumn childColumn = childrenTable.Columns["KodeCust"];
            DataRelation customerToChildren = new DataRelation("CustomerToChildren", parentColumn, childColumn);
            dataSet.Relations.Add(customerToChildren);

            //Load CustomerList from the dataSet
            CustomerItem nextCustomer = null;
            ChildrenItem nextChildren = null;
            foreach (DataRow parentRow in customerTable.Rows)
            {
                //Create a new Customer
                nextCustomer = new CustomerItem(false);

                //Fill in Customer Properties
                nextCustomer.KodeCust = parentRow["KodeCust"].ToString();
                nextCustomer.NamaCust = parentRow["NamaCust"].ToString();
                nextCustomer.Alamat = parentRow["Alamat"].ToString();
                nextCustomer.Email = parentRow["Email"].ToString();
                nextCustomer.Telepon = parentRow["Telp"].ToString();
                nextCustomer.TglMasuk = Convert.ToDateTime(parentRow["tgl_masuk"]);
                nextCustomer.IsDiscount = Convert.ToBoolean(parentRow["Spesial_Diskon"]);
                nextCustomer.IsPercent = Convert.ToBoolean(parentRow["isPercent"]);
                nextCustomer.Diskon = Convert.ToDouble(parentRow["diskon"]);
                nextCustomer.Keterangan = parentRow["Ket"].ToString();

                //Get Children
                DataRow[] childRows = parentRow.GetChildRows(customerToChildren);

                //Create children object for each of the invoice
                foreach (DataRow childRow in childRows)
                {
                    //Create a new children
                    nextChildren = new ChildrenItem();

                    //Fill in children Properties
                    nextChildren.Kodeanak = childRow["KodeAnak"].ToString();
                    nextChildren.KodeCust = childRow["KodeCust"].ToString();
                    nextChildren.Nama = childRow["Nama"].ToString();
                    nextChildren.NamaAyah = childRow["NamaAyah"].ToString();
                    nextChildren.NamaIbu = childRow["NamaIbu"].ToString();
                    nextChildren.JenisKelamin = childRow["JenisKelamin"].ToString();
                    nextChildren.TglLahir = Convert.ToDateTime(childRow["TglLahir"]);
                    nextChildren.TempatLahir = childRow["TempatLahir"].ToString();

                    //Add Children to customer
                    nextCustomer.Items.Add(nextChildren);
                }
                //Add the customer to the customer list
                customerList.Add(nextCustomer);
            }
            //set isbinsdingComplete to add another null value without user knowing (Failed)
            IsBindingComplete = true;

            //Dispose of the dataset
            dataSet.Dispose();   
        }
        #endregion
    }
}
