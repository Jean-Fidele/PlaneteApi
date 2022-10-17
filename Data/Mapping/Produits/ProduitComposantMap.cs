using Domain.Entites.Produits;
using Domain.Entites.Reservations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Produits
{
    public class ProduitComposantMap : IEntityTypeConfiguration<ProduitComposant>
    {
        public void Configure(EntityTypeBuilder<ProduitComposant> builder)
        {
            
        }
    }
}
