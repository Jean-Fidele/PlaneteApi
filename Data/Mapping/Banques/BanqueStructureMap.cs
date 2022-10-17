using Domain.Entites.Banques;
using Domain.Entites.Devises;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Banques
{
    public class BanqueStructureMap : IEntityTypeConfiguration<BanqueStructure>
    {
        public void Configure(EntityTypeBuilder<BanqueStructure> builder)
        {
            
        }
    }
}
