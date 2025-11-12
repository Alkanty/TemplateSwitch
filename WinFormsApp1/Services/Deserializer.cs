using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    // SYSTEM NAME
    public class SystemName
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
    }

    // ENABLE DHCP SERVER
    public class DhcpServer
    {
        public string line1 { get; set; }
    }

    // ENABLE DHCP SNOOPING PROTECTION
    public class DhcpSnoopingProtection
    {
        public string line1 { get; set; }
    }


    //ROOT CLASS FOR DESERIALIZATION
    public class Root
    {
        public SystemName systemname { get; set; }
        public DhcpServer dhcpserver { get; set; }
        public DhcpSnoopingProtection dhcpsnoopingprotection { get; set; }
    }
}
