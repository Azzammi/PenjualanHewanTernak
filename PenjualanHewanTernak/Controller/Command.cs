using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenjualanHewanTernak.Controller
{
    public abstract class Command
    {
        //Method
        public abstract object Execute();
    }
}
