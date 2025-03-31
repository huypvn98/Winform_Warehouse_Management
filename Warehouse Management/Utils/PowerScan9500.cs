using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Utils
{
    public class PowerScan9500 : COMPortBase
    {
        public PowerScan9500()
        {
            _portName = GlobalSetting.ScannerSOPort;
            _encoding = Encoding.GetEncoding("Windows-1252");
        }
    }
}
