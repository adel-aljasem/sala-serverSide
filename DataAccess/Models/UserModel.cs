using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class UserModel
    {
       
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        [EmailAddress]    
        public string Email { get; set; }
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="هذا الحقل الزامي")]
        public string StoreLink { get; set; }
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        public string StoreName { get; set; }
        [Required(ErrorMessage = "هذا الحقل الزامي")]
        public string StoreType { get; set; }

    }
}
