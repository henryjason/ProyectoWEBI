using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_WebII.Models
{
    public class Interacions
    {


            public Int32 id { get; set; }
          
            public Int32 id_user { get; set; }
          
            public String name { get; set; }
            public String url { get; set; }
        
            public String action { get; set; }
           
            public String verb { get; set; }
          
            public String parametro { get; set; }

    }
}