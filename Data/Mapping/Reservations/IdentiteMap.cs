using Domain.Entites.Reservations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Reservations
{
    public class IdentiteMap : IEntityTypeConfiguration<Identite>
    {
        public void Configure(EntityTypeBuilder<Identite> builder)
        {
            
        }
    }
}
