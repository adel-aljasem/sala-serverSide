using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Product
    {
        public int ID { get; set; }
        public int? IDCategory { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public virtual List<Image> Images { get; set; }
        [ForeignKey("IDCategory")]
        public virtual Category Category { get; set; }

        public virtual ProductDetails ProductDetails { get; set; } 

    }
}
