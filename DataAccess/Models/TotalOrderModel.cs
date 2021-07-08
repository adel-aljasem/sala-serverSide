using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TotalOrderModel
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string IdUser { get; set; }
        public int TotalPrice { get; set; }

        public List<OrderModel> OrdersModel { get; set; }
        public ApplicationUser User { get; set; }

    }
}
