using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_WebI.Models
{
    public class Recomentacion
    {
        [Required]
        public Int32 ID { get; set; }
        [Required]
        public String Name { get; set; }
        public String Télefono { get; set; }
        [Required]
        public String Email { get; set; }
        public String Comentario { get; set; }
       
    }

    public class DBRecomentaciones : DbContext
    {
        public DbSet<Recomentacion> oRecomendacion { get; set; }
    }

}