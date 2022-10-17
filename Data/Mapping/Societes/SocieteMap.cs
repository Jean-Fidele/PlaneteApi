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
            
        }
    }
}
