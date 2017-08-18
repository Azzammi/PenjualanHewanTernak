using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Jenis
{
    class CommandUpdateJenis : Command
    {
        #region Declarations
        JenisItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdateJenis(JenisItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.UpdateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
