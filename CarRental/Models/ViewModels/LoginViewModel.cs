using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Номер водительского удостоверения")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }
        public string  ReturnUrl { get; set; }
    }
}
