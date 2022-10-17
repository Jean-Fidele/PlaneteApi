using Domain.Entites.Objets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Objets
{
    public class OutillageMap : IEntityTypeConfiguration<Outillage>
    {
        public void Configure(EntityTypeBuilder<Outillage> builder)
        {
            
        }
    }
}
