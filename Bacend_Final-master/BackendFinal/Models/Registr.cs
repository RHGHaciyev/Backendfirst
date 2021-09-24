using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackendFinal.Models
{
    public class Registr
    {
        [Required(ErrorMessage = "Please enter name")]     
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter surname", AllowEmptyStrings = false)]
        public string surname { get; set; }

        [Required(ErrorMessage = "Please enter age", AllowEmptyStrings = false)]
        public int age { get; set; }

        [Required(ErrorMessage = "Please enter email", AllowEmptyStrings = false)]
        public string email { get; set; }
       
        public Nullable<int> phone { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [MinLength(8, ErrorMessage = "8 characters required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}