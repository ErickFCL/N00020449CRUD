using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using N00020449CRUD.Models.Mapa;

namespace N00020449CRUD.Models
{
    public class PersonaContexto : DbContext
    {
        
            public DbSet<Cuenta> Cuentas { get; set; }

            public PersonaContexto(DbContextOptions<PersonaContexto> options) : base(options)
            {


            }

            public PersonaContexto()
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.ApplyConfiguration(new CuentaMap());
            }
        }
}
