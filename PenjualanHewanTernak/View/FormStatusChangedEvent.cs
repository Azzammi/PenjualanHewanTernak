using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanHewanTernak.View
{
    public enum Status
    {
        addNewMode,
        editMode
    }

    public class FormStatusChangedEventArgs : EventArgs
    {
        #region Declaration
        public Status formStatus;
        #endregion

        #region Constructor
        public FormStatusChangedEventArgs(Status status)
        {
            formStatus = status;
        }
        #endregion

        #region Properties
        public Status FormStatus
        {
            get { return formStatus; }           
        }
        #endregion
    }

    public delegate void FormStatusChangedEventHandler(object sender, FormStatusChangedEventArgs e);
}


