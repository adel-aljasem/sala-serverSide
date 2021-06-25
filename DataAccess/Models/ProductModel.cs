using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ProductModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="حقل الزامي")]
        public int? IDCategory { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "حقل الزامي")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "يجب ادخال ارقام فقط")]
        public string Price { get; set; }
        [Required(ErrorMessage = "حقل الزامي")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "يجب ادخال ارقام فقط")]
        public string Quantity { get; set; }
        public List<ImageModel> Images { get; set; } = new List<ImageModel>();
        public CategoryModel CategoryModel { get; set; } 
        public virtual ProductDetailsModel ProductModelDetails { get; set; } = new ProductDetailsModel();
    }
}
