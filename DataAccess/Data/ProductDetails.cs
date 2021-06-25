using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ProductDetails
    {
        [Key]
        public int Id { get; set; }
        public int IDProduct { get; set; }
        public bool Shipment { get; set; }
        public int Weight { get; set; }
        public long SKU { get; set; }
        public int CostPrice { get; set; }
        public int DiscoutPrice { get; set; }
        public string Details { get; set; }
        [ForeignKey("IDProduct")]
        public virtual Product Product { get; set; }
    }
}
