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
    public class PaysMap : IEntityTypeConfiguration<Pays>
    {
        public void Configure(EntityTypeBuilder<Pays> builder)
        {
            builder.ToTable("Pays");
            builder.HasKey(x => x.PaysId);
            builder.HasData(
                new Pays { PaysId = 1, Code2car = "AW", Code3car = "ABW", CodeChiffre = 533, Fuseauhoraire = null, LibelleENG= "ARUBA", LibelleFR = "ARUBA" },
                new Pays { PaysId = 2, Code2car = "AF", Code3car = "AFG", CodeChiffre = 4, Fuseauhoraire = null, LibelleENG = "AFGHANISTAN", LibelleFR = "AFGHANISTAN" },
                new Pays { PaysId = 3, Code2car = "AO", Code3car = "AGO", CodeChiffre = 24, Fuseauhoraire = null, LibelleENG = "ANGOLA", LibelleFR = "ANGOLA" },
                new Pays { PaysId = 4, Code2car = "AI", Code3car = "AIA", CodeChiffre = 660, Fuseauhoraire = null, LibelleENG = "ANGUILLA", LibelleFR = "ANGUILLA" },
                new Pays { PaysId = 5, Code2car = "AL", Code3car = "ALB", CodeChiffre = 8, Fuseauhoraire = null, LibelleENG = "ALBANIE", LibelleFR = "ALBANIE" },
                new Pays { PaysId = 6, Code2car = "AD", Code3car = "AND", CodeChiffre = 20, Fuseauhoraire = null, LibelleENG = "ANDORRES", LibelleFR = "ANDORRES" },
                new Pays { PaysId = 7, Code2car = "AN", Code3car = "ANT", CodeChiffre = 530, Fuseauhoraire = null, LibelleENG = "NETHERLANDS ANTILLES", LibelleFR = "NETHERLANDS ANTILLES" },
                new Pays { PaysId = 8, Code2car = "AE", Code3car = "ARE", CodeChiffre = 784, Fuseauhoraire = null, LibelleENG = "EMIRATS ARABES UNIS", LibelleFR = "EMIRATS ARABES UNIS" },
                new Pays { PaysId = 9, Code2car = "AR", Code3car = "ARG", CodeChiffre = 32, Fuseauhoraire = null, LibelleENG = "ARGENTINE", LibelleFR = "ARGENTINE" }
            );
        }
    }
}
