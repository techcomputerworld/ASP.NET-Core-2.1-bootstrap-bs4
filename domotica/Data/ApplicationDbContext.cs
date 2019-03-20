using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace domotica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private DbContextOptionsBuilder<ApplicationDbContext> options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //aquí añadimos las tablas que vamos a usar en la apliación 
        public DbSet<Usuarios> Usuarios { get; set; }

     
    }
}
