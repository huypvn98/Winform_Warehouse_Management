using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class ORGANIZATION
    {
        public int IdOrg { get; set; }

        public string MaNhaMay { get; set; }

        public string MaOrg { get; set; }

        public string TenOrg { get; set; }

        public string LocationCode { get; set; }

        public string LocationName { get; set; }

        public byte OrgType { get; set; }

        public int? WarehouseId { get; set; }

        public bool IsOrgSanXuat => OrgType == 0;

        public bool IsOrgThanhPham => OrgType == 1;

        public bool IsOrgHangHoa => OrgType == 2;

        public string MaOrgText
        {
            get
            {
                if (IdOrg == -1)
                {
                    return "Tất cả";
                }
                if (IdOrg == -2)
                {
                    return "Không chọn";
                }
                return MaOrg;
            }
        }
    }
}
