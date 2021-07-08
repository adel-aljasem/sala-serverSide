using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public int IdTotalOrder { get; set; }
        public int Quantity { get; set; }
        public bool Paid { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        [ForeignKey("IdProduct")]
        public Product Product { get; set; }
        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }

    }
}
