using Domain.Entites.Societes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Societes
{
    public class CiviliteMap : IEntityTypeConfiguration<Civilite>
    {
        public void Configure(EntityTypeBuilder<Civilite> builder)
        {
            builder.ToTable("Civilite");
            builder.HasKey(x => x.CiviliteId);
            builder.HasData(
                new Civilite { CiviliteId = 1, Code = "M", Libelle = "Monsieur" },
                new Civilite { CiviliteId = 2, Code = "Mme", Libelle = "Madame" },
                new Civilite { CiviliteId = 3, Code = "Mlle", Libelle = "Mademoiselle" },
                new Civilite { CiviliteId = 4, Code = "Mx", Libelle = "Neutre" }
            );
        }
    }
}
