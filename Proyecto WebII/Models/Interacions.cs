using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_WebII.Models
{
    public class Interacions
    {


            [Required]
            public Int32 id { get; set; }
            [Required]
            public Int32 id_user { get; set; }
            [Required]
            public String name { get; set; }
            public String url { get; set; }
            [Required]
            public String action { get; set; }
            [Required]
            public String verb { get; set; }
            [Required]
            public String parametro { get; set; }

    }
}