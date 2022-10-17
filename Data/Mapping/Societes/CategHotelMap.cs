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
    public class CategHotelMap : IEntityTypeConfiguration<CategHotel>
    {
        public void Configure(EntityTypeBuilder<CategHotel> builder)
        {
            builder.ToTable("CategHotel");
            builder.HasKey(x => x.CategHotelId);
            builder.HasData(
               new CategHotel { CategHotelId = 1, Libelle = "1 étoile" },
               new CategHotel { CategHotelId = 2, Libelle = "2 étoiles" },
               new CategHotel { CategHotelId = 3, Libelle = "3 étoiles" },
               new CategHotel { CategHotelId = 4, Libelle = "4 étoiles" },
               new CategHotel { CategHotelId = 5, Libelle = "5 étoiles" }
            );
        }
    }
}
