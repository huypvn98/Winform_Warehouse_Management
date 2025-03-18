using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class FACTORY
    {
        public int ID_FACTORY { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string FactoryName { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Hotline { get; set; }

        public bool IsHead { get; set; }
    }
}
