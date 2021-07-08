using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public bool Reply { get; set; }

        [ForeignKey("IdProduct")]
        public Product Product { get; set; }
        [ForeignKey("IdUser")]
        public ApplicationUser User { get; set; }
    }
}
