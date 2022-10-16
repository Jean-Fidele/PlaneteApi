using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping
{
    public class DomaineMap : IEntityTypeConfiguration<Domaine>
    {
        public void Configure(EntityTypeBuilder<Domaine> builder)
        {
            builder.ToTable("Domain");
            builder.HasKey(x => x.DomaineId);
            builder.Property(x => x.DomaineId);
            builder.Property(x => x.Code);
            builder.Property(x => x.Libelle);
        }
    }
}
