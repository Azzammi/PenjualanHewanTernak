using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
namespace PenjualanHewanTernak.Controller.Grade
{
    class CommandGetGrade : Command
    {
        #region Declaration

        #endregion

        #region Methods
        public override object Execute()
        {
            GradeList list = new GradeList();
            return list;
        }
        #endregion
    }
}
