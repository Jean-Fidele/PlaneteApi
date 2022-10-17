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
    public class FraisMap : IEntityTypeConfiguration<Domain.Entites.Frais.Frais>
    {
        public void Configure(EntityTypeBuilder<Domain.Entites.Frais.Frais> builder)
        {
            
        }
    }
}
