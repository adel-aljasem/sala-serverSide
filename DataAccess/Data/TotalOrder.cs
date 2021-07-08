using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class TotalOrder
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<Order> Orders { get; set; }
        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }

    }
}
