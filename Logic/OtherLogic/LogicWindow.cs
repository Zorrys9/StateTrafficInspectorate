using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.OtherLogic
{
    public class LogicWindow
    {

        public static void FromAddLicense()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.AddLicense;
        }
        public static void FromDriverList()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.DriverList;
        }
        public static void FromAddTransport()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.AddTransport;
        }
        public static void FromAddInsurance()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.AddInsurance;
        }
        public static void FromChangeDriver()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.ChangeDriver;
        }
        public static void FromTransportList()
        {
            SecurityContext.CurrentWindow = Enums.EnumWindow.TransportList;
        }

    }
}
