﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pengeluaran
{
    class CommandUpdatePosPengeluaran : Command
    {
        #region Declaration
        posPengeluaranItem m_Item;
        #endregion

        #region Constuctor
        public CommandUpdatePosPengeluaran(posPengeluaranItem item)
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
