using Microsoft.EntityFrameworkCore;
using RegistrodePrestamo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrodePrestamo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }



    }
}
