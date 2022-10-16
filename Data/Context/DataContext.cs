using Data.Mapping.Societes;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategComptableMap());
            builder.ApplyConfiguration(new CategFacturationMap());
            builder.ApplyConfiguration(new CategHotelMap());
            builder.ApplyConfiguration(new CiviliteMap());
            builder.ApplyConfiguration(new CollaborateurMap());
            builder.ApplyConfiguration(new CompteMap());
            builder.ApplyConfiguration(new ContactMap());
            builder.ApplyConfiguration(new DepartementMap());
            builder.ApplyConfiguration(new FormeJuridiqueMap());
            builder.ApplyConfiguration(new MetierMap());
            builder.ApplyConfiguration(new PaysMap());
            builder.ApplyConfiguration(new ProfessionnelMap());
            builder.ApplyConfiguration(new ServiceMap());
            builder.ApplyConfiguration(new SocieteMap());
            base.OnModelCreating(builder);
        }
    }
}
