using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="خانة الزامية")]
        public string Name { get; set; }
    }
}
