using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_WebII.Models
{
    public class reportes
    {

  [Required]
        public Int32 id { get; set; }
        public Int32 id_user { get; set; }
        public String result { get; set; }

    }
}