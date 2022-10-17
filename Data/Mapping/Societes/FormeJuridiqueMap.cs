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
    public class FormeJuridiqueMap : IEntityTypeConfiguration<FormeJuridique>
    {
        public void Configure(EntityTypeBuilder<FormeJuridique> builder)
        {
            builder.ToTable("FormeJuridique");
            builder.HasKey(x => x.FormeJuridiqueId);
            builder.HasData(
               new FormeJuridique { FormeJuridiqueId = 101, Code = "EI", Libelle = "Entreprise Individuelle" },
               new FormeJuridique { FormeJuridiqueId = 102, Code = "SARL", Libelle = "Société à Responsabilité Limitée" },
               new FormeJuridique { FormeJuridiqueId = 103, Code = "SA", Libelle = "Société Anonyme" },
               new FormeJuridique { FormeJuridiqueId = 104, Code = "SNC", Libelle = "Société en Nom Collectif" },
               new FormeJuridique { FormeJuridiqueId = 105, Code = "SCS", Libelle = "Société en Commandite Simple" },
               new FormeJuridique { FormeJuridiqueId = 106, Code = "GIE", Libelle = "Groupement d'Intérêt Economique" },
               new FormeJuridique { FormeJuridiqueId = 107, Code = "SDET", Libelle = "Société de Droit Etranger" }
            );
        }
    }
}
