using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace pruebamvc.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Conexion")
        {

        }
        public DbSet<Empleados> empleados { set; get; }
    }
}