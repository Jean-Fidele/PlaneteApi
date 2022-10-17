using Domain.Entites.Produits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Produits
{
    public class CategTarifaireMap : IEntityTypeConfiguration<CategTarifaire>
    {
        public void Configure(EntityTypeBuilder<CategTarifaire> builder)
        {
            
        }
    }
}
