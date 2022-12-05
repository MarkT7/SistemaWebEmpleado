using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SistemaWebEmpleadoTejerina.Models;

namespace SistemaWebEmpleadoTejerina.Data
{
    public class EmpleadoDBContext:DbContext
    {
        public EmpleadoDBContext():base(@"Data Source =.; Initial Catalog = EmpleadoDB; Integrated Security = True") { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}