using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_WebII.Models
{
    public class Login_Register
    {

        [Required]
        public Int32 id { get; set; }
        [Required]
        public String name { get; set; }
        public String telefono { get; set; }
        [Required]
        public String email { get; set; }
          [Required]
        public String username { get; set; }
          [Required]
        public String pass{ get; set; }
       

    }

}