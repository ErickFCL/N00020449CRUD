using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace N00020449CRUD.Models.Mapa
{
    public class CuentaMap : IEntityTypeConfiguration<Cuenta>
    {
        
            public void Configure(EntityTypeBuilder<Cuenta> builder)
            {
                builder.ToTable("Cuenta");
                builder.HasKey(o => o.DNI);
            }
        
    }
}
