using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ProductDetailsModel
    {
        public int Id { get; set; }
        public int IDProduct { get; set; }
        public bool Shipment { get; set; }
        public int Weight { get; set; }
        public long SKU { get; set; }
        public int CostPrice { get; set; }
        public int DiscoutPrice { get; set; }
        public string Details { get; set; }
        public ProductModel Product { get; set; }

    }
}
