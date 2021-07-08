using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string IdUser { get; set; }
        public DateTime DateTime { get; set; }

        public string Message { get; set; }
        public bool Reply { get; set; }


        public ProductModel ProductModel { get; set; }
        public ApplicationUser User { get; set; }
    }
}
