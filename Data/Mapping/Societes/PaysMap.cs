﻿using Domain.Entites.Societes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Societes
{
    public class PaysMap : IEntityTypeConfiguration<Pays>
    {
        public void Configure(EntityTypeBuilder<Pays> builder)
        {
            builder.ToTable("Pays");
            builder.HasKey(x => x.PaysId);
            builder.HasData(new Pays { PaysId = 101, Code2car = "FR", Code3car = "FRS" });
        }
    }
}
