using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenjualanHewanTernak.Controller;
using PenjualanHewanTernak.Controller.Customer;
using PenjualanHewanTernak.Controller.Children;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmCustomer : Form
    {
        #region Declaration
        AppController m_AppController;
        CustomerList m_CustomerList;       
        bool isInitialized = false;
        #endregion

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            isInitialized = false;

            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Customer List
            CommandGetCustomer getItem = new CommandGetCustomer();
            m_CustomerList = (CustomerList)m_AppController.ExecuteCommand(getItem);


            //Bind to datasource
            customerItemBindingSource.DataSource = m_CustomerList;
            itemsBindingSource.DataSource = customerItemBindingSource;
            itemsBindingSource.DataMember = "Items";

            isInitialized = m_CustomerList.IsBindingComplete;
        }
        
        private void itemsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime authors
             * list has been passed in. */

            // Exit if no project list
            if (m_CustomerList == null) return;

            //Assign parent 
            CustomerItem parent = (CustomerItem)customerItemBindingSource.Current;

            // Create a new children
            CommandInsertChildren createChildren = new CommandInsertChildren(parent.KodeCust);
            ChildrenItem newChildren = (ChildrenItem)m_AppController.ExecuteCommand(createChildren);

            /* Since the BindingSource is managing the collection, we pass the new 
             * author to the BindingSource, using the NewObject property of the 
             * event args. The BindingSource will add the new author to the 
             * AuthorList for us. */

            // Add it to theAuthors list
            e.NewObject = newChildren;
        }

        private void itemsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime author
             * list has been passed in. */

            // Exit if no parent
            CustomerItem parent = (CustomerItem)customerItemBindingSource.Current;
            if (parent == null) return;

            // Get the item affected
            int index = e.NewIndex;
            ChildrenItem changedItem = null;
            if ((index > -1) && (index < parent.Items.Count))
            {
                changedItem = parent.Items[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            /* We only need to respond to two types of changes here; updates
             * and moves. Adds are handled by bindingSourceAuthors_AddingNew(),
             * and deletes are handled by menuItemBooksDelete_Click(). */

            // Dispatch a change handler
            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    CommandUpdateChildren updateItem = new CommandUpdateChildren(changedItem);
                    m_AppController.ExecuteCommand(updateItem);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //if Customer List not selected then do nothing
            //if (m_CustomerList == null) return;

            //Assign currentCustomer
            CustomerItem currentCustomer = (CustomerItem)customerItemBindingSource.Current;

            //If currentCustomer is empty then do nothing
            if (currentCustomer == null) return ;

            if (isInitialized)
            {
              
            }
            else
            {
                CommandUpdateCustomer updateCustomer = new CommandUpdateCustomer(currentCustomer);
                m_AppController.ExecuteCommand(updateCustomer);
            }
        }

        private void customerItemBindingSource_AddingNew_1(object sender, AddingNewEventArgs e)
        {
            if (isInitialized == true)
            {
                if (m_CustomerList == null) return;

                CommandInsertCustomer createCustomer = new CommandInsertCustomer();
                CustomerItem newCustomer = (CustomerItem)m_AppController.ExecuteCommand(createCustomer);

                e.NewObject = newCustomer;
            }            
        }

        private void customerItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime author
             * list has been passed in. */

            // Exit if no parent
            if (m_CustomerList == null) return;

            // Get the item affected
            int index = e.NewIndex;
            CustomerItem changedItem = null;
            if ((index > -1) && (index < m_CustomerList.Count))
            {
                changedItem = m_CustomerList[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            /* We only need to respond to two types of changes here; updates
             * and moves. Adds are handled by bindingSourceAuthors_AddingNew(),
             * and deletes are handled by menuItemBooksDelete_Click(). */

            // Dispatch a change handler
            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    CommandUpdateCustomer updateCustomer = new CommandUpdateCustomer(changedItem);
                    m_AppController.ExecuteCommand(updateCustomer);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void customerItemBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            isInitialized = true;
        }
        
    }
}
