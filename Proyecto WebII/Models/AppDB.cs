﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto_WebII.Models
{
    public class AppDB : DbContext
    {

     public AppDB()
            : base("DBProyecto")
        {

        }

     public DbSet<Login_Register> oLogin_Register { get; set; }
     public DbSet<Interacions> oInteracion { get; set; }
     public DbSet<reportes> oReportes { get; set; }
    }

}