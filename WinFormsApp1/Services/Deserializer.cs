using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    //CLASS FOR SYSTEM NAME DESERIALIZATION
    public class SystemName
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
    }

    //ROOT CLASS FOR DESERIALIZATION
    public class Root
    {
        public SystemName system_name { get; set; }
    }
}
