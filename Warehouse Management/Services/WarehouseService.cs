using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Models;

namespace Warehouse_Management.Services
{
    public class WarehouseService : ServiceBase
    {
        private string _uri = "api/Warehouse/";

        public List<Warehouse> GetWarehouse()
        {
            string uri = _uri + "GetListWarehouse/";
            return Task.Run(async () => await Get<List<Warehouse>>(uri)).Result;
        }

        public List<Warehouse> GetWarehouseMaterial()
        {
            string uri = _uri + "GetListWarehouseMaterial/";
            return Task.Run(async () => await Get<List<Warehouse>>(uri)).Result;
        }

        public List<Warehouse> GetAllWarehouses()
        {
            string uri = _uri + "GetListAllWarehouses/";
            return Task.Run(async () => await Get<List<Warehouse>>(uri)).Result;
        }
    }
}
