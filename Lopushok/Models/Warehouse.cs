using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopushok.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }

        public virtual ICollection<WarehouseProduct>? WarehouseProduct { get; set; }
    }
}
