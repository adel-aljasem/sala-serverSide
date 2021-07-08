using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public int? IdTotalOrder { get; set; }

        [Range(1,100,ErrorMessage ="الحد الاقصى 100 والحد الادنى 1")]
        public int Quantity { get; set; } = 1;
        public bool Paid { get; set; }
        public DateTime Date { get; set; }

        public int Price { get; set; }
        public ProductModel ProductModel { get; set; }
        public ApplicationUser User { get; set; }

    }
}
