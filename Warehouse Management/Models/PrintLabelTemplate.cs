using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class PrintLabelTemplate
    {
        public int WidthLabel { get; set; }

        public int HeightLabel { get; set; }

        public int QRCodeImageWidth { get; set; }

        public int PixelsPerModule { get; set; }

        public string ECCLevel { get; set; }

        public string Content { get; set; }
    }

}
