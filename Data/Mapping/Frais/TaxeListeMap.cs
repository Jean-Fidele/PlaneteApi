using Domain.Entites.Frais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Frais
{
    public class TaxeListeMap : IEntityTypeConfiguration<TaxeListe>
    {
        public void Configure(EntityTypeBuilder<TaxeListe> builder)
        {
            
        }
    }
}
