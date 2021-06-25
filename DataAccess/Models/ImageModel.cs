using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ImageModel
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
