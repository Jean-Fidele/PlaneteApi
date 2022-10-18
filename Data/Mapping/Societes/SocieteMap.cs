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
    public class SocieteMap : IEntityTypeConfiguration<Societe>
    {
        public void Configure(EntityTypeBuilder<Societe> builder)
        {
            builder.ToTable("Societe");
            builder.HasKey(x => x.SocieteId);
            builder.HasData(new Societe
            {
                SocieteId = 1, 
                Nom = "O3 Consulting", 
                Adresse = "Analamahitsy", 
                AdressCompl = "Ambohibao",
                Capital = 10000, 
                CategHotelId = 1, 
                Email = "fidele999@gmail.com", 
                PaysId = 1, 
                FormeJuridiqueId = 101
            });
        }
    }
}
