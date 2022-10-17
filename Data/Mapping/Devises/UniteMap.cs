using Domain.Entites.Devises;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Devises
{
    public class UniteMap : IEntityTypeConfiguration<Unite>
    {
        public void Configure(EntityTypeBuilder<Unite> builder)
        {
            
        }
    }
}
