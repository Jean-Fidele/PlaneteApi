using Domain.Entites.Objets;
using Domain.Entites.Produits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Objets
{
    public class DomaineMap : IEntityTypeConfiguration<Domaine>
    {
        public void Configure(EntityTypeBuilder<Domaine> builder)
        {
            
        }
    }
}
