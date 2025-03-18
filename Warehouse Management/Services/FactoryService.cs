using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Models;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Services
{
    public class FactoryService : ServiceBase
    {
        private string _uri = "api/factory/";

        public List<FACTORY> GetFactory()
        {
            string uri = _uri + "getlist/";
            return Task.Run(async () => await Get<List<FACTORY>>(uri)).Result;
        }

        public Response<OrgResp> GetOrganization()
        {
            string uri = _uri + "GetListOrgV2/?username=" + Helper.EscapeDataString(GlobalSetting.Username);
            return Task.Run(async () => await GetResp<OrgResp>(uri)).Result;
        }
        public List<ORGANIZATION> GetAllOrgsForPrint()
        {
            string uri = "api/account/getlistorg/";
            return Task.Run(async () => await Get<List<ORGANIZATION>>(uri)).Result;
        }
    }
}
