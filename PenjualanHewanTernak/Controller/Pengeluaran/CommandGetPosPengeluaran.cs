﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pengeluaran
{
    class CommandGetPosPengeluaran : Command
    {
        #region Constructor
        public CommandGetPosPengeluaran() { }
        #endregion

        #region Method
        public override object Execute()
        {
            PosPengeluaranList list = new PosPengeluaranList();
            return list;
        }
        #endregion
    }
}
